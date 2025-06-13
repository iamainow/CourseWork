namespace i
{
	namespace Data
	{
		public static class Format
		{
			public class iFormat
			{
				public string NAME;
				public float WIDTH;
				public float HEIGHT;
				public iFormat()
				{
					this.NAME=string.Empty;
					this.WIDTH=0;
					this.HEIGHT=0;
				}
				public iFormat(string Name,float Width,float Height)
				{
					this.NAME=Name;
					this.WIDTH=Width;
					this.HEIGHT=Height;
				}
				public void Serialize(i.Security.iBinaryWriter BW)
				{
					BW.Write(this.NAME);
					BW.Write(this.WIDTH);
					BW.Write(this.HEIGHT);
				}
				public static iFormat DeSerialize(i.Security.iBinaryReader BR)
				{
					return new iFormat(BR.ReadString(),BR.ReadSingle(),BR.ReadSingle());
				}
				public override string ToString()
				{
					return this.NAME+" "+this.HEIGHT.ToString()+" x "+this.WIDTH.ToString();
				}
			}
			public static readonly iFormat A0=new iFormat("A0",840,1188);
			public static readonly iFormat A1=new iFormat("A1",594,840);
			public static readonly iFormat A2=new iFormat("A2",420,594);
			public static readonly iFormat A3=new iFormat("A3",297,420);
			public static readonly iFormat A4=new iFormat("A4",210,297);
			public static readonly iFormat A5=new iFormat("A5",148,210);
			public static readonly iFormat A6=new iFormat("A6",105,148);
			public static readonly iFormat A7=new iFormat("A7",74,105);
			public static iFormat[] Formats
			{
				get
				{
					return new iFormat[]
					{
						A0,
						A1,
						A2,
						A3,
						A4,
						A5,
						A6,
						A7,
					};
				}
			}
		}
		public class iDataCollection:System.Collections.Generic.List<iData>
		{
			private int N;
			public iDataCollection() : base()
			{
				this.N=1;
			}
			protected void Save(i.Security.iBinaryWriter BW)
			{
				BW.Write(this.N);
				foreach(i.Data.iData D in this)
				{
					D.Serialize(BW);
				}
				BW.Close();
			}
			public void Save(string File)
			{
				this.Save(new i.Security.iBinaryWriter(System.IO.File.Open(File,System.IO.FileMode.Create)));
			}
			public void Save(string File,string Password)
			{
				this.Save(new i.Security.iBinaryWriter(System.IO.File.Open(File,System.IO.FileMode.Create),Password));
			}
			protected void Load(i.Security.iBinaryReader BR)
			{
				this.Clear();
				try
				{
					this.N=BR.ReadInt32();
					while(BR.Position<BR.Length)
					{
						this.Add(i.Data.iData.DeSerialize(BR));
					}
				}
				finally
				{
					BR.Close();
				}
			}
			public void Load(string File)
			{
				this.Load(new i.Security.iBinaryReader(System.IO.File.Open(File,System.IO.FileMode.Open)));
			}
			public void Load(string File,string Password)
			{
				this.Load(new i.Security.iBinaryReader(System.IO.File.Open(File,System.IO.FileMode.Open),Password));
			}
			public Data.iData New(Data.CID CID)
			{
				Data.iData Data=i.Data.iData.Create(CID);
				Data.ID=this.N++;
				base.Add(Data);
				return Data;
			}
			public Data.iData[] NewRange(Data.CID CID,int Count)
			{
				Data.iData[] Data=new iData[Count];
				for(int i1=0;i1<Count;i1++)
				{
					Data[i1]=this.New(CID);
				}
				this.AddRange(Data);
				return Data;
			}
			public void Delete(i.Data.iData Data)
			{
				this.Remove(Data);
				for(int i1=0;i1<base.Count;i1++)
				{
					if(base[i1] is i.Data.iAssembly)
					{
						(base[i1] as i.Data.iAssembly).DRAUGHTS.RemoveAll((I) => I==Data.ID);
					}
				}
				for(int i1=0;i1<base.Count;i1++)
				{
					if(base[i1] is i.Data.iDraught)
					{
						(base[i1] as i.Data.iDraught).PARTS.RemoveAll((I) => I==Data.ID);
					}
				}
				for(int i1=0;i1<base.Count;i1++)
				{
					if(base[i1] is i.Data.iGroup)
					{
						(base[i1] as i.Data.iGroup).PARTS.RemoveAll((I) => I==Data.ID);
					}
				}
			}
			public new void Clear()
			{
				base.Clear();
				this.N=0;
			}
		}
		public abstract class iData
		{
			public static iData Create(CID CID)
			{
				switch(CID)
				{
					case Data.CID.Assembly:
						return new iAssembly();
					case Data.CID.Draught:
						return new iDraught();
					case Data.CID.Group:
						return new iGroup();
					case Data.CID.Part:
						return new iPart();
					default:
						throw new System.Exception("Unknown ID in i.Data.Create(CID)");
				}
			}
			public int ID;
			public abstract Data.CID CID
			{
				get;
			}
			public iData()
			{
				this.ID=0;
			}
			public iData(int ID)
			{
				this.ID=ID;
			}																 
			public void Serialize(i.Security.iBinaryWriter BW)
			{
				BW.Write((byte)this.CID);
				BW.Write(this.ID);
				this.SelfSerialize(BW);
			}
			public static iData DeSerialize(i.Security.iBinaryReader BR)
			{
				iData Data=i.Data.iData.Create((Data.CID)BR.ReadByte());
				Data.ID=BR.ReadInt32();
				Data.SelfDeSerialize(BR);
				return Data;
			}
			protected abstract void SelfSerialize(i.Security.iBinaryWriter BW);
			protected abstract void SelfDeSerialize(i.Security.iBinaryReader BR);
			public abstract override string ToString();
		}
		public class iAssembly:iData
		{
			public string NAME;
			public byte DIFF;
			public System.Collections.Generic.List<int> DRAUGHTS;
			public override Data.CID CID
			{
				get
				{
					return Data.CID.Assembly;
				}
			}
			public iAssembly() : base()
			{
				this.NAME=string.Empty;
				this.DIFF=0;
				this.DRAUGHTS=new System.Collections.Generic.List<int>(0);
			}
			public iAssembly(int ID) : base(ID)
			{
				this.NAME=string.Empty;
				this.DIFF=0;
				this.DRAUGHTS=new System.Collections.Generic.List<int>(0);
			}
			public iAssembly(string Name,byte Diff,System.Collections.Generic.List<int> Draughts) : base()
			{
				this.NAME=Name;
				this.DIFF=Diff;
				this.DRAUGHTS=Draughts;
			}
			public iAssembly(int ID,string Name,byte Diff,System.Collections.Generic.List<int> Draughts) : base(ID)
			{
				this.NAME=Name;
				this.DIFF=Diff;
				this.DRAUGHTS=Draughts;
			}
			protected override void SelfSerialize(i.Security.iBinaryWriter BW)
			{
				BW.Write(this.NAME);
				BW.Write(this.DIFF);
				BW.Write(this.DRAUGHTS.Count);
				for(int i1=0;i1<this.DRAUGHTS.Count;i1++)
				{
					BW.Write(this.DRAUGHTS[i1]);
				}
			}
			protected override void SelfDeSerialize(i.Security.iBinaryReader BR)
			{
				this.NAME=BR.ReadString();
				this.DIFF=BR.ReadByte();
				int Count=BR.ReadInt32();
				this.DRAUGHTS=new System.Collections.Generic.List<int>(Count);
				for(int i1=0;i1<Count;i1++)
				{
					this.DRAUGHTS.Add(BR.ReadInt32());
				}
			}
			public static byte AutoDiff(i.Data.iAssembly Assembly)
			{
				return Assembly.DRAUGHTS.Count<100 ? (byte)Assembly.DRAUGHTS.Count : (byte)100;
			}
			public override string ToString()
			{
				return "Assembly "+this.ID.ToString()+" '"+this.NAME+"'";
			}
		}
		public class iDraught:iData
		{
			public string NAME;
			public int INDEX;
			public Data.Format.iFormat FORMAT;
			public System.Collections.Generic.List<int> PARTS;
			public override Data.CID CID
			{
				get
				{
					return Data.CID.Draught;
				}
			}
			public iDraught() : base()
			{
				this.NAME=string.Empty;
				this.INDEX=0;
				this.FORMAT=new Format.iFormat();
				this.PARTS=new System.Collections.Generic.List<int>(0);
			}
			public iDraught(int ID) : base(ID)
			{
				this.NAME=string.Empty;
				this.INDEX=0;
				this.FORMAT=new Format.iFormat();
				this.PARTS=new System.Collections.Generic.List<int>(0);
			}
			public iDraught(string Name,int Index,Format.iFormat Format,System.Collections.Generic.List<int> Parts) : base()
			{
				this.NAME=Name;
				this.INDEX=Index;
				this.FORMAT=Format;
				this.PARTS=Parts;
			}
			public iDraught(int ID,string Name,int Index,Format.iFormat Format,System.Collections.Generic.List<int> Parts) : base(ID)
			{
				this.NAME=Name;
				this.INDEX=Index;
				this.FORMAT=Format;
				this.PARTS=Parts;
			}
			protected override void SelfSerialize(i.Security.iBinaryWriter BW)
			{
				BW.Write(this.NAME);
				BW.Write(this.INDEX);
				this.FORMAT.Serialize(BW);
				BW.Write(this.PARTS.Count);
				for(int i1=0;i1<this.PARTS.Count;i1++)
				{
					BW.Write(this.PARTS[i1]);
				}
			}
			protected override void SelfDeSerialize(i.Security.iBinaryReader BR)
			{
				this.NAME=BR.ReadString();
				this.INDEX=BR.ReadInt32();
				this.FORMAT=Data.Format.iFormat.DeSerialize(BR);
				int Count=BR.ReadInt32();
				this.PARTS=new System.Collections.Generic.List<int>(Count);
				for(int i1=0;i1<Count;i1++)
				{
					this.PARTS.Add(BR.ReadInt32());
				}
			}
			public override string ToString()
			{
				return "Draught "+this.ID.ToString()+" '"+this.NAME+"'";
			}
		}
		public class iGroup:iData
		{
			public string NAME;
			public System.Collections.Generic.List<int> PARTS;
			public override Data.CID CID
			{
				get
				{
					return Data.CID.Group;
				}
			}
			public iGroup() : base()
			{
				this.NAME=string.Empty;
				this.PARTS=new System.Collections.Generic.List<int>(0);
			}
			public iGroup(int ID) : base(ID)
			{
				this.NAME=string.Empty;
				this.PARTS=new System.Collections.Generic.List<int>(0);
			}
			public iGroup(string Name,System.Collections.Generic.List<int> Parts) : base()
			{
				this.NAME=Name;
				this.PARTS=Parts;
			}
			public iGroup(int ID,string Name,System.Collections.Generic.List<int> Parts) : base(ID)
			{
				this.NAME=Name;
				this.PARTS=Parts;
			}
			protected override void SelfSerialize(i.Security.iBinaryWriter BW)
			{
				BW.Write(this.NAME);
				BW.Write(this.PARTS.Count);
				for(int i1=0;i1<this.PARTS.Count;i1++)
				{
					BW.Write(this.PARTS[i1]);
				}
			}
			protected override void SelfDeSerialize(i.Security.iBinaryReader BR)
			{
				this.NAME=BR.ReadString();
				int Count=BR.ReadInt32();
				this.PARTS=new System.Collections.Generic.List<int>(Count);
				for(int i1=0;i1<Count;i1++)
				{
					this.PARTS.Add(BR.ReadInt32());
				}
			}
			public override string ToString()
			{
				return "Group "+this.ID.ToString()+" '"+this.NAME+"'";
			}
		}
		public class iPart:iData
		{
			public string NAME;
			public byte NEW;
			public byte DIFF;
			public bool DONE;
			public int DRAUGHT;
			public override Data.CID CID
			{
				get
				{
					return Data.CID.Part;
				}
			}
			public iPart() : base()
			{
				this.NAME=string.Empty;
				this.NEW=0;
				this.DIFF=0;
			}
			public iPart(int ID) : base(ID)
			{
				this.NAME=string.Empty;
				this.NEW=0;
				this.DIFF=0;
			}
			public iPart(string Name,byte New,byte Diff,bool Done,int Draught) : base()
			{
				this.NAME=Name;
				this.NEW=New;
				this.DIFF=Diff;
				this.DONE=Done;
				this.DRAUGHT=Draught;
			}
			public iPart(int ID,string Name,byte New,byte Diff,bool Done,int Draught) : base(ID)
			{
				this.NAME=Name;
				this.NEW=New;
				this.DIFF=Diff;
				this.DONE=Done;
				this.DRAUGHT=Draught;
			}
			protected override void SelfSerialize(i.Security.iBinaryWriter BW)
			{
				BW.Write(this.NAME);
				BW.Write(this.NEW);
				BW.Write(this.DIFF);
				BW.Write(this.DONE);
				BW.Write(this.DRAUGHT);
			}
			protected override void SelfDeSerialize(i.Security.iBinaryReader BR)
			{
				this.NAME=BR.ReadString();
				this.NEW=BR.ReadByte();
				this.DIFF=BR.ReadByte();
				this.DONE=BR.ReadBoolean();
				this.DRAUGHT=BR.ReadInt32();
			}
			public override string ToString()
			{
				return "Part "+this.ID.ToString()+" '"+this.NAME+"'";
			}
		}
		public enum CID:byte
		{
			Assembly,
			Draught,
			Group,
			Part,
		}
	}
	namespace Security
	{
		public class iEncoder
		{
			private iPassword PASSWORD;
			public iEncoder()
			{
				this.PASSWORD=null;
			}
			public iEncoder(string Password)
			{
				if(Password==string.Empty)
				{
					this.PASSWORD=null;
				}
				else
				{
					this.PASSWORD=new iPassword(Password);
				}
			}
			public iEncoder(byte[] Password)
			{
				if(Password.Length==0)
				{
					this.PASSWORD=null;
				}
				else
				{
					this.PASSWORD=new iPassword(Password);
				}
				this.PASSWORD=new iPassword(Password);
			}
			public byte Encode(byte Value)
			{
				if(this.PASSWORD==null)
				{
					return Value;
				}
				else
				{
					return (byte)(Value^this.PASSWORD.Next());
				}
			}
			public byte[] Encode(byte[] Value)
			{
				byte[] Byte=new byte[Value.Length];
				for(int i1=0;i1<Byte.Length;i1++)
				{
					Byte[i1]=this.Encode(Value[i1]);
				}
				return Byte;
			}
			public bool Encode(bool Value)
			{
				return System.BitConverter.ToBoolean(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public short Encode(short Value)
			{
				return System.BitConverter.ToInt16(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public ushort Encode(ushort Value)
			{
				return System.BitConverter.ToUInt16(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public int Encode(int Value)
			{
				return System.BitConverter.ToInt32(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public uint Encode(uint Value)
			{
				return System.BitConverter.ToUInt32(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public long Encode(long Value)
			{
				return System.BitConverter.ToInt64(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public ulong Encode(ulong Value)
			{
				return System.BitConverter.ToUInt64(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public float Encode(float Value)
			{
				return System.BitConverter.ToSingle(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public double Encode(double Value)
			{
				return System.BitConverter.ToDouble(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public char Encode(char Value)
			{
				return System.BitConverter.ToChar(this.Encode(System.BitConverter.GetBytes(Value)),0);
			}
			public string Encode(string Value)
			{
				return System.Text.Encoding.Unicode.GetString(this.Encode(System.Text.Encoding.Unicode.GetBytes(Value)));
			}
		}
		public class iPassword
		{
			private int POSITION;
			private byte[] DATA;
			public int Position
			{
				get
				{
					return this.POSITION;
				}
				set
				{
					this.Position=(value>=this.DATA.Length) ? 0 : value;
				}
			}
			public int Length
			{
				get
				{
					return this.DATA.Length;
				}
			}
			public iPassword(string Password)
			{
				this.DATA=System.Text.Encoding.Unicode.GetBytes(Password);
			}
			public iPassword(byte[] Password)
			{
				this.DATA=Password;
			}
			public byte Next()
			{
				return this.DATA[Position++];
			}
			public byte[] Next(int Length)
			{
				byte[] Byte=new byte[Length];
				for(int i1=0;i1<Byte.Length;i1++)
				{
					Byte[i1]=this.Next();
				}
				return Byte;
			}
		}
		public class iBinaryWriter
		{
			private System.IO.BinaryWriter BW;
			private i.Security.iEncoder ENCODER;
			public iBinaryWriter(System.IO.Stream Stream)
			{
				this.BW=new System.IO.BinaryWriter(Stream);
				this.ENCODER=new iEncoder();
			}
			public iBinaryWriter(System.IO.Stream Stream,string Password)
			{
				this.BW=new System.IO.BinaryWriter(Stream);
				this.ENCODER=new iEncoder(Password);
			}
			public iBinaryWriter(System.IO.Stream Stream,byte[] Password)
			{
				this.BW=new System.IO.BinaryWriter(Stream);
				this.ENCODER=new iEncoder(Password);
			}
			public long Position
			{
				get
				{
					return BW.BaseStream.Position;
				}
			}
			public long Length
			{
				get
				{
					return BW.BaseStream.Length;
				}
			}
			public void Write(byte value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(byte[] value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(bool value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(short value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(ushort value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(int value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(uint value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(long value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(ulong value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(float value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(double value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(char value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Write(string value)
			{
				this.BW.Write(this.ENCODER.Encode(value));
			}
			public void Close()
			{
				BW.Close();
			}
			public static implicit operator System.IO.BinaryWriter(iBinaryWriter BW)
			{
				return BW.BW;
			}
		}
		public class iBinaryReader
		{
			private System.IO.BinaryReader BR;
			private i.Security.iEncoder ENCODER;
			public iBinaryReader(System.IO.Stream Stream)
			{
				this.BR=new System.IO.BinaryReader(Stream);
				this.ENCODER=new iEncoder();
			}
			public iBinaryReader(System.IO.Stream Stream,string Password)
			{
				this.BR=new System.IO.BinaryReader(Stream);
				this.ENCODER=new iEncoder(Password);
			}
			public iBinaryReader(System.IO.Stream Stream,byte[] Password)
			{
				this.BR=new System.IO.BinaryReader(Stream);
				this.ENCODER=new iEncoder(Password);
			}
			public long Position
			{
				get
				{
					return this.BR.BaseStream.Position;
				}
			}
			public long Length
			{
				get
				{
					return this.BR.BaseStream.Length;
				}
			}
			public byte ReadByte()
			{
				return this.ENCODER.Encode(this.BR.ReadByte());
			}
			public byte[] ReadBytes(int Count)
			{
				return this.ENCODER.Encode(this.BR.ReadBytes(Count));
			}
			public bool ReadBoolean()
			{
				return this.ENCODER.Encode(this.BR.ReadBoolean());
			}
			public short ReadInt16()
			{
				return this.ENCODER.Encode(this.BR.ReadInt16());
			}
			public ushort ReadUInt16()
			{
				return this.ENCODER.Encode(this.BR.ReadUInt16());
			}
			public int ReadInt32()
			{
				return this.ENCODER.Encode(this.BR.ReadInt32());
			}
			public uint ReadUInt32()
			{
				return this.ENCODER.Encode(this.BR.ReadUInt32());
			}
			public long ReadInt64()
			{
				return this.ENCODER.Encode(this.BR.ReadInt64());
			}
			public ulong ReadUInt64()
			{
				return this.ENCODER.Encode(this.BR.ReadUInt64());
			}
			public float ReadSingle()
			{
				return this.ENCODER.Encode(this.BR.ReadSingle());
			}
			public double ReadDouble()
			{
				return this.ENCODER.Encode(this.BR.ReadDouble());
			}
			public char ReadChar()
			{
				return this.ENCODER.Encode(this.BR.ReadChar());
			}
			public string ReadString()
			{
				return this.ENCODER.Encode(this.BR.ReadString());
			}
			public void Close()
			{
				this.BR.Close();
			}
			public static implicit operator System.IO.BinaryReader(iBinaryReader BR)
			{
				return BR.BR;
			}
		}
	}
}
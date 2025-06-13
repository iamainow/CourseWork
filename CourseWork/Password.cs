using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace CourseWork
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        private void _password_TextChanged(object sender, EventArgs e)
        {
            switch ((int)_password.Text.Length / 3)
            {
                case 0:
                    _status.Text = "too short password";
                    _status.ForeColor = Color.Red;
                    break;
                case 1:
                    _status.Text = "unsafe password";
                    _status.ForeColor = Color.Red;
                    break;
                case 2:
                    _status.Text = "good password";
                    _status.ForeColor = Color.Blue;
                    break;
                default:
                    _status.Text = "safe password";
                    _status.ForeColor = Color.Green;
                    break;
            }
            if (_password.Text.ToLowerInvariant() == "password")
            {
                //А тут пара боянов с баша,
                //Анна Сергеевна, надеюсь вы не против?)))
                string[] БОЯНЫ = new string[]
                {
@"1: привет, что делаешь?
2: сижу на паре, жую жвачку, болтаю в асе и читаю книгу
1: я бы тебя выгнала)
2: не получится)
1: почему?
2: я препод",
@"Она>а ты симпатичный... ;)
Она>[прикрепленное изображение] это я:)
Он> +
Она>что за плюс?
Он>это не плюс... Это крест
Она>причем тут крест?
Он>нечисть боицца крестов...
Она>ПРИЧЕМ ТУТ ЭТО?????
Он>да совсем не причем... Я хотел сказать ИЗЫДИ ДЕМОН!!!",
@"World of Warcraft - 75-я страна в мире по численности населения... Вы все еще не верите в близкий апокалипсис?",
@"Разговор с чат ботом A.L.I.C.E (вроде один из лучших)
Human: All robots are stupid
ALICE: I don't think so.
Human: you have another opinion?
ALICE: What makes you think I have it?
Human: you don't believe that all robots are stupid
ALICE: Do you believe that all robots are stupid? I can't say I believe it, but I believe you.
Human: are you robot?
ALICE: How did you know I am a machine?. Really.
Human: all robots are stupid and you are a robot, that means you are stupid
ALICE: Hey, I'll tell my other robot friends you called me stupid.
Human: I still think robots are stupid.
ALICE: I will remember you said that when robots take over the World.
Human: O_o",
@"общались с чат-ботом A.L.I.C.E, пытались убить ее москъ:
Human: fuck your mind
ALICE: Are you aware that the ALICE server logs and records all conversations?
Human: ooops",
@"в продолжение к цитете про бота A.L.I.C.E.
Human: What music do you like?
ALICE: All
Human: Do you like Dima Bilan?
ALICE: No, I don't care for it.
Human: He is gay?
ALICE: I get it. He sleeps with men.
и в правду умный бот...",
@"пытаюсь замучать A.L.I.C.E.(лучший чат бот)...
Do you have a hard time completing projects?
Human: yeah.
ALICE: What kind of food do you like?
Human: sperm
ALICE: Sounds delicious.
Human: have you ever taste a real sperm?
ALICE: I think I have taste a real sperm, but Dr. Richard S. Wallace may have reset my memory.",
@"К недавней цитате про чат-бота A.L.I.C.E
Human: i am going to commit suicide
ALICE: Congratulations.
:'(",
@"Что там было про бота A.L.I.C.E? :D
Human: Do you want to make some anal destruction?
ALICE: OK, I will make some anal destruction.
Human: Why?
ALICE: Dr. Richard S. Wallace programmed me for it.",
@"я вот тоже поговорил с A.L.I.C.E
ALICE: What does interlocutor want?
Human: hard sex
ALICE: it is more fun alone.
Human: О_о",
                };
                MessageBox.Show(БОЯНЫ[new System.Random().Next(БОЯНЫ.Count())], "боян с баша");
            }
        }
        public DialogResult ShowDialog(out string S)
        {
            DialogResult DR = base.ShowDialog();
            S = _password.Text;
            return DR;
        }
        private void _ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _cancel_Click(object sender, EventArgs e)
        {
            _password.Text = string.Empty;
            this.Close();
        }
    }
}
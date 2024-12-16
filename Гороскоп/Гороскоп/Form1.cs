using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            //Отображения сегоднейшей даты
            Dataonline.Text += Convert.ToString(dateTimePicker1.Value);
        }
        public string StarSign { get; set; }
        public bool PressButton;
        private void какУзнатьСвойЗзToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаю экземпляр формы dateSigns
            dateSigns dateS = new dateSigns();
            //Вывожу её на экран
            dateS.ShowDialog();
        }
        //Показываю информацию о выбранном знаке в контекстном меню
        private void овенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Овен: Этот знак — вечный гонщик в супермаркете. Всегда первым на распродаже, но забывает, что ему нужно не только взять, но и заплатить.");
        }

        private void телецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Телец: Настоящий гурман, который может устроить пикник из чипсов и колы на диване. У него есть неофициальный титул «Король Лени», но он предпочитает, чтобы его звали «Мастером Удовольствий».");
        }

        private void близнецыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Близнецы: Два человека в одном теле, которые постоянно спорят о том, что смотреть по телевизору. Один из них всегда хочет комедию, а другой — документалку о жизни улиток.");
        }

        private void ракToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рак: Этот знак — эмоциональный моллюск. Он всегда носит с собой запасной плед и может расплакаться даже из-за того, что у него закончился шоколад.");
        }

        private void левToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лев: Главный актер в собственном мюзикле, который ставит каждую сцену в своем воображении. У него есть золотая корона из фольги, которую он носит с гордостью.");
        }

        private void деваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дева: Педант с суперспособностями к организации. Может за 5 минут составить план по уборке всего мира, но при этом потеряет свои ключи.");
        }

        private void весыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Весы: Постоянно взвешивают все решения на весах справедливости, но в итоге выбирают пиццу вместо салата. Их девиз: «Почему бы не оба?»");
        }

        private void скорпионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скорпион: Мастер шпионских игр, который всегда знает, где кто оставил свои носки. Его хобби — разгадывать загадки и строить теории заговора о том, почему его кактус не цветет.");
        }

        private void стрелецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стрелец: Путешественник без паспорта, который всегда мечтает о приключениях, но чаще всего оказывается на диване с книжкой о путешествиях.");
        }

        private void козерогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Козерог: Работяга с амбициями, который строит карьеру с помощью блокнота и чашки кофе. Его мечта — стать CEO своей собственной компании по производству пончиков.");
        }

        private void водолейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Водолей: Экспериментатор и изобретатель, который однажды решил создать машину времени из тостера и микроволновки. В итоге просто поджарил хлеб.");
        }

        private void рыбыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рыбы: Художник, который рисует мир в своих мечтах и иногда забывает, что нужно выходить на улицу. Их любимое занятие — сочинять песни о том, как сложно найти свои носки.");
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            //Отметка о том что кнопка нажималась при выбранном знаке зодиака
            PressButton = true;
            //Выполняем функции взависимости от выбранного знака зодиака
            switch (cmbSign.SelectedIndex)
            {
                case 0:
                    StarSign = "Овен: ";
                    break;
                case 1:
                    StarSign = "Телец: ";
                    break;
                case 2:
                    StarSign = "Близнецы: ";
                    break; 
                case 3:
                    StarSign = "Рак: ";
                    break;
                case 4:
                    StarSign = "Лев: ";
                    break;
                case 5:
                    StarSign = "Дева: ";
                    break;
                case 6:
                    StarSign = "Весы: ";
                    break;
                case 7:
                    StarSign = "Скорпион: ";
                    break;
                case 8:
                    StarSign = "Стрелец: ";
                    break;
                case 9:
                    StarSign = "Козерог: ";
                    break;
                case 10:
                    StarSign = "Водолей: ";
                    break;
                case 11:
                    StarSign = "Рыбы: ";
                    break; 
            }
            Random rnd = new Random();
            switch (rnd.Next(0,11))// Тут я представляю что я астролог и делаю невероятно точный прогноз для выбранного знака зодиака
            {
                case 0:
                    StarSign += "Сегодня, если ты будешь доброжелателен и приветлив, на протяжении дня тебя будут ждать только улыбающиеся люди и… один очень настойчивый продавец пылесосов. Будь готов к неожиданным демонстрациям!";
                    break;
                case 1:
                    StarSign += "Если ты сегодня решишь поесть что-то необычное, то твой обед станет настоящим кулинарным шедевром. Однако будь осторожен: твой кот может попытаться присвоить себе лавры шеф-повара.";
                    break;
                case 2:
                    StarSign += "Сегодня, если ты будешь много говорить, то твои слова могут случайно превратиться в песню. Готовься, возможно, тебе предстоит записать хит и стать звездой TikTok, но сначала не забудь найти рифму к слову «пирог».";
                    break;
                case 3:
                    StarSign += "Если сегодня ты решишь остаться дома и устроить себе уютный вечер, то твои растения могут начать вести с тобой философские беседы. Не бойся, они просто хотят обсудить последние новости из мира горшков.";
                    break;
                case 4:
                    StarSign += "Сегодня, если ты будешь вести себя как король (или королева), то окружающие будут следовать за тобой… в магазин за мороженым. Не забудь взять с собой свою золотую ложку для истинного королевского наслаждения!";
                    break;
                case 5:
                    StarSign += "Если ты сегодня решишь все организовать, то твоя жизнь станет идеальной и упорядоченной… до тех пор, пока кто-то не решит перемешать твои носки. Будь готов к экстренному разбору полетов!";
                    break;
                case 6:
                    StarSign += "Если сегодня ты найдешь время для выбора между двумя одинаковыми пирожками, то это может занять весь день. Но не переживай: в конце концов ты всё равно выберешь третий, который неожиданно появится!";
                    break;
                case 7:
                    StarSign += "Если сегодня ты решишь отправиться в приключение, то, возможно, окажешься в поисках идеального места для селфи. Но помни: лучшее место может оказаться прямо у твоего холодильника!";
                    break;
                case 8:
                    StarSign += "Если ты сегодня будешь работать усердно, то в конце дня тебя ждет награда — пакет чипсов. Не забудь проверить, не притаился ли в нем приз в виде игрушки из 90-х!";
                    break;
                case 9:
                    StarSign += "Если сегодня ты проявишь свою креативность, то сможешь создать что-то совершенно уникальное… например, новый способ завязывать шнурки. Будь готов к тому, что твои друзья могут захотеть записать об этом видео!";
                    break;
                case 10:
                    StarSign += "Сегодня, если ты решишь быть загадочным, то окружающие будут пытаться разгадать твою тайну. Но будь осторожен: твоя тайна может оказаться просто тем, что ты забыл выключить утюг.";
                    break;
                case 11:
                    StarSign += "Если сегодня ты погрузишься в свои мечты, то можешь неожиданно обнаружить, что твой диван — это корабль в открытом море. Не забудь запастись попкорном на случай встречи с воображаемыми морскими чудовищами!";
                    break;
            }
            StarSigns sign = new StarSigns(StarSign);
            sign.ShowDialog();
        }

        private void cmbSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Блокировка кнопки при не выбранном знаке зодиака
            butStart.Enabled = true;
            //При смене знака зодиака кнопка ещё не нажалось
            PressButton = false;
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PressButton == true)//Нажатость кнопки при выбранном знаке задиака
            {
                SaveFileDialog sfd = new SaveFileDialog();//Диалоговое окно для сохранения файла
                sfd.Filter = "Text Files (*.txt)| *.txt";//Сохраняемый формат .txt
                if (sfd.ShowDialog() == DialogResult.OK)//Проверка на нажатие кнопки сохранить
                {
                    string fileName = sfd.FileName;
                    System.IO.File.WriteAllText(fileName, StarSign);
                }
                else
                {
                    return;//Возращаюсь назад
                }
            }
        }
    }
}

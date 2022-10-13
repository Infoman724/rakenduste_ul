using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace rakenduste_ul
{
    public partial class MeediaPlayer : Form
    {

        List<string> filteredFiles = new List<string>();//список выбранных файлов "filtered" типа "string"                                            
        FolderBrowserDialog browser = new FolderBrowserDialog();//обьявление всплывающего диалога для выбора файл/ов/а
        int currentFile = 0;//изначальное количество файлов "currentFile" равно нулю

        public MeediaPlayer()
        {
            components = new Container();//контейнер для организации элементов управления в связанные группы по типу flowlayout panel
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MeediaPlayer));
            menuStrip1 = new MenuStrip();//создание элемента меню с выпадающим списком
            ToolStripMenuEseme = new  ToolStripMenuItem();//создание элемента меню
            loadFolderMenuEseme = new ToolStripMenuItem();//создание элемента меню "loadFolder"
            aboutToolStripMenuEseme = new ToolStripMenuItem();//создание элемента меню "about"
            VideoPLayer = new AxWMPLib.AxWindowsMediaPlayer();//создание AxWindowsMediaPlayer ""
            Playlist = new  ListBox();//создание "Playlist" типа "ListBox"
            filiNimi = new  Label();//создание "failiNimi" типа "Label"
            lblKestus = new Label();//создание "lblKestus" типа "Label"
            timer1 = new Timer(this.components);//создание таймера
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPLayer)).BeginInit(); //3 строчки кода чтобы элемента не расползались изза бага
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            ToolStripMenuEseme});
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1310, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuEseme
            // 
            ToolStripMenuEseme.DropDownItems.AddRange(new ToolStripItem[] {
            loadFolderMenuEseme,
            aboutToolStripMenuEseme});
            ToolStripMenuEseme.Name = "MenuuAsi";
            ToolStripMenuEseme.Size = new System.Drawing.Size(44, 24);
            ToolStripMenuEseme.Text = "file";
            // 
            // loadFolderMenuEseme
            // 
            loadFolderMenuEseme.Name = "loadFolderMenuEseme";
            loadFolderMenuEseme.Size = new Size(167, 26);
            loadFolderMenuEseme.Text = "LoadFolder";
            loadFolderMenuEseme.Click += new EventHandler(this.LoadFolderEvent);
            // 
            // aboutToolStripMenuEseme
            // 
            aboutToolStripMenuEseme.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuEseme.Size = new Size(167, 26);
            aboutToolStripMenuEseme.Text = "About";
            aboutToolStripMenuEseme.Click += new EventHandler(this.ShowAboutEvent);
            // 
            // VideoPLayer
            // 
            VideoPLayer.Enabled = true;
            VideoPLayer.Location = new Point(0, 31);
            VideoPLayer.Name = "VideoPLayer";
            VideoPLayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPLayer.OcxState")));
            VideoPLayer.Size = new Size(631, 397);
            VideoPLayer.TabIndex = 1;
            VideoPLayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaMuudaEvent);
            // 
            // Playlist
            // 
            Playlist.FormattingEnabled = true;
            Playlist.ItemHeight = 16;
            Playlist.Location = new Point(849, 31);
            Playlist.Name = "Playlist";
            Playlist.RightToLeft = RightToLeft.Yes;
            Playlist.Size = new Size(163, 388);
            Playlist.TabIndex = 2;
            Playlist.SelectedIndexChanged += new EventHandler(this.PlayListMuudatud);
            // 
            // fileName
            // 
            filiNimi.AutoSize = true;
            filiNimi.Location = new Point(12, 534);
            filiNimi.Name = "fileName";
            filiNimi.Size = new Size(69, 16);
            filiNimi.TabIndex = 3;
            filiNimi.Text = "File Name";
            // 
            // lblDuration
            // 
            lblKestus.AutoSize = true;
            lblKestus.Location = new Point(846, 422);
            lblKestus.Name = "lblDuration";
            lblKestus.Size = new Size(67, 16);
            lblKestus.TabIndex = 4;
            lblKestus.Text = "Duration:0";
            // 
            // timer1
            // 
            timer1.Tick += new EventHandler(this.TimerEvent);
            // 
            // MeediaPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 558);
            Controls.Add(lblKestus);//{
            Controls.Add(filiNimi);
            Controls.Add(Playlist);     // добавления обьектов в контейнер/ на экран
            Controls.Add(VideoPLayer);
            Controls.Add(menuStrip1);//}
            MainMenuStrip = menuStrip1;
            Name = "MeediaPlayer";
            Text = "Meedia Player";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void LoadFolderEvent(object sender, EventArgs e)//метод загрузки папки
        {
            VideoPLayer.Ctlcontrols.stop();//сначала останавливает произведение файлов если что то играло

            if (filteredFiles.Count > 1)//если количество файлов в списке больше одного то
            {
                filteredFiles.Clear();//очищаем список
                filteredFiles = null;//приравниваем к нулю

                Playlist.Items.Clear();//очищаем плейлист/ ListBox

                currentFile = 0;//приравниваем данный файл к нулю
            }

            DialogResult result = browser.ShowDialog();//открывает диалог выбора файла

            if (result == DialogResult.OK)//если ответ был ок/ файл/папка был выбран
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();//здесь мы приравниваем наш списко файлов к файлам выбранным из директории с точкой заканчивающийся на -форматы файлов указанные в коде в нижнем регистре

                LaadigePlayList();//после того как файл был выбран и определен как нужный формат запускается функция загрузки в плейлист 
            }


        }

        private void ShowAboutEvent(object sender, EventArgs e)//метод выводящее информацию о проекте
        {
            MessageBox.Show("Selle form rakkendatud Vlademir Gužov" + Environment.NewLine + "Klõpsake nuppu Ava kaust, et laadida videokaust rakendusse ja see hakkab automaatselt esitama" + Environment.NewLine + "Nautige. P.S see app võib esita ainult mp4,wmv,mkv,avi,webm formaat video!!!", "App ");
        }

        private void MediaMuudaEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)//метод выводящий информацию в зависимости от сосотояния медиа проигрывателя переменная "e" равна событию "AxWMPLib._WMPOCXEvents_PlayStateChangeEvent"
        {
            if (e.newState == 0)//в положении 0   информацию о положениях смотреть в самом низу
            {
                //загрузка завершена/подтверждена

                lblKestus.Text = "Media Player is Ready to be loaded";
            }
            else if (e.newState == 1)//в положении 1
            {
                // если файл перестал воспроизводится

                lblKestus.Text = "Media Player stopped";
            }
            else if (e.newState == 3)//в положении 3
            {
                // если файл работает 

                lblKestus.Text = "Duration: " + VideoPLayer.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // если файл закончил воспроизведение

                if (currentFile >= filteredFiles.Count - 1)//если данный файл больше или равен количеству файлов в списке -1
                {
                    currentFile = 0;//приравниваем к нул.
                }
                else
                {
                    currentFile += 1;//по иному +1
                }

                Playlist.SelectedIndex = currentFile;// и индекс плейлиста приравниваем к нынешнему файлу

                NaitaFailiNimi(filiNimi);//и показываем имя файла

            }
            else if (e.newState == 9)//если загружается новое видео
            {
                
                lblKestus.Text = "Loading new video";
            }
            else if (e.newState == 10)//если вмдео сново готов к воспроизведению
            {
                
                timer1.Start();

            }

        }

        private void PlayListMuudatud(object sender, EventArgs e)//метож если плейлист был изменен (чтото добавили например)
        {
            currentFile = Playlist.SelectedIndex;//текущий файл приравнивается к текущему выбраному индексу плейлиста
            EsitaFaili(Playlist.SelectedItem.ToString());//используя метод "EsitaFaili" переводим текущий выбранный плейлистом обьект в "string"
            NaitaFailiNimi(filiNimi);//и показываем его имя
        }

        private void TimerEvent(object sender, EventArgs e)//метод для таймера запускающий видео плеер и останавливающий таймер
        {
            VideoPLayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LaadigePlayList()//метод добавления в плейлист
        {
            VideoPLayer.currentPlaylist = VideoPLayer.newPlaylist("PlayList", "");//текущий плейлист равен новому плейлисту видеоплеера

            foreach (string videos in filteredFiles)//за каждое видео типа "string" в списке
            {
                VideoPLayer.currentPlaylist.appendItem(VideoPLayer.newMedia(videos));//в текущий плейлист добавляем видео из списка
                Playlist.Items.Add(videos);//добавляем видео
            }

            if (filteredFiles.Count > 0)//если количество файлов в списке больше 0
            {
                filiNimi.Text = "Files Found " + filteredFiles.Count;//отображаем "Files Found " + количество файлов

                Playlist.SelectedIndex = currentFile;//текущий индекс плейлиста приравнивается к текущему файлу

                EsitaFaili(Playlist.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No Video Files Found in this folder");//по иному показать то что в этой папке нету файлов
            }
        }

        private void EsitaFaili(string url)//функция запускающая файл по данному url типа "string"
        {
            VideoPLayer.URL = url;
        }

        private void NaitaFailiNimi(Label name)//метод для демонстрации имени файла
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        MenuStrip menuStrip1;
        ToolStripMenuItem ToolStripMenuEseme;
        ToolStripMenuItem loadFolderMenuEseme;
        ToolStripMenuItem aboutToolStripMenuEseme;          //обьявление наших обьектов
        AxWMPLib.AxWindowsMediaPlayer VideoPLayer;
        ListBox Playlist;
        Label filiNimi;
        Label lblKestus;
        Timer timer1;

    }
}

/*
 case 0:    // Undefined
            currentStateLabel.Text = "Undefined";
            break;

        case 1:    // Stopped
            currentStateLabel.Text = "Stopped";
            break;

        case 2:    // Paused
            currentStateLabel.Text = "Paused";
            break;

        case 3:    // Playing
            currentStateLabel.Text = "Playing";
            break;

        case 4:    // ScanForward
            currentStateLabel.Text = "ScanForward";
            break;

        case 5:    // ScanReverse
            currentStateLabel.Text = "ScanReverse";
            break;

        case 6:    // Buffering
            currentStateLabel.Text = "Buffering";
            break;

        case 7:    // Waiting
            currentStateLabel.Text = "Waiting";
            break;

        case 8:    // MediaEnded
            currentStateLabel.Text = "MediaEnded";
            break;

        case 9:    // Transitioning
            currentStateLabel.Text = "Transitioning";
            break;

        case 10:   // Ready
            currentStateLabel.Text = "Ready";
            break;

        case 11:   // Reconnecting
            currentStateLabel.Text = "Reconnecting";
            break;

        case 12:   // Last
            currentStateLabel.Text = "Last";
            break;

        default:
            currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
            break;
 */
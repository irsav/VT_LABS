using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB07
{
    public partial class Form1 : Form
    {
        // ListBox — список элементов управления и диалогов (левая часть интерфейса)
        private ListBox listBox;

        // root — основной контейнер, делит форму на 2 части (меню + контент)
        private TableLayoutPanel root;

        // header — заголовок справа, показывает выбранный пункт
        private Label header;

        // content — контейнер для динамического размещения элементов
        private TableLayoutPanel content;

        // timer — используется в заданиях (например, часы или ProgressBar)
        private System.Windows.Forms.Timer timer;

        // Цвета темы интерфейса (тёмная тема)
        // Общий Цвет Фона
        private Color bg = Color.FromArgb(43, 43, 43);

        // Цвет правой панели
        private Color panelBg = Color.FromArgb(60, 63, 65);

        // Цвет Шрифта
        private Color fg = Color.FromArgb(169, 183, 198);

        // =========================
        // Задание 1: Конструктор формы
        // =========================
        public Form1()
        {

            Text = "Лабораторная 7";
            Size = new Size(1000, 600);
            Font = new Font("JetBrains Mono NL", 20);
            BackColor = bg;
            ForeColor = fg;

            root = new TableLayoutPanel();
            root.Dock = DockStyle.Fill;
            root.ColumnCount = 2;
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Controls.Add(root);

            InitListBox();
            InitRightPanel();
        }

        // =========================
        // Задание 2: Инициализация ListBox
        // =========================
        private void InitListBox()
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.BackColor = panelBg;
            listBox.ForeColor = fg;
            listBox.BorderStyle = BorderStyle.None;

            listBox.Items.AddRange(new string[]
            {
        "DateTimePicker",
        "NumericUpDown",
        "PictureBox",
        "TrackBar",
        "Timer",
        "ProgressBar",
        "ComboBox",
        "MessageBox",
        "ColorDialog",
        "OpenFileDialog",
        "FontDialog",
        "Немодальное окно"
            });

            listBox.SelectedIndexChanged += OnSelect;

            root.Controls.Add(listBox, 0, 0);
        }

        // =========================
        // Задание 3: Правая панель (заголовок + контент)
        // =========================
        private void InitRightPanel()
        {
            TableLayoutPanel right = new TableLayoutPanel();
            right.Dock = DockStyle.Fill;
            right.RowCount = 2;
            right.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            right.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            header = new Label();
            header.Dock = DockStyle.Fill;
            header.Padding = new Padding(10);
            header.TextAlign = ContentAlignment.MiddleLeft;

            content = new TableLayoutPanel();
            content.AutoScroll = true;
            content.Dock = DockStyle.Fill;
            content.Padding = new Padding(20);
            content.BackColor = panelBg;

            right.Controls.Add(header, 0, 0);
            right.Controls.Add(content, 0, 1);

            root.Controls.Add(right, 1, 0);
        }

        // =========================
        // Задание 4: Заголовок
        // =========================
        private void SetHeader(string text)
        {
            header.Text = "Демонстрация работы: " + text;
        }

        // =========================
        // Задание 5: Очистка панели
        // =========================
       private void Clear()
{
    content.Controls.Clear();
    content.RowStyles.Clear();
    content.RowCount = 0;
    if (timer != null)
    {
        timer.Stop();
    }
}

        // =========================
        // Готовый метод (использовать)
        // =========================
        private void AddControl(Control c)
        {
            c.Dock = DockStyle.Top;
            c.Margin = new Padding(0, 0, 0, 15);
            c.BackColor = panelBg;
            c.ForeColor = fg;

            content.RowCount++;
            content.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            content.Controls.Add(c, 0, content.RowCount - 1);
        }

        // =========================
        // Задание 6: Обработка выбора
        // =========================
        private void OnSelect(object sender, EventArgs e)
        {
            Clear();
            string selected = listBox.SelectedItem.ToString();
            SetHeader(selected);

            switch (listBox.SelectedIndex)
            {
                case 0: DateTimeDemo(); break;
                case 1: NumericDemo(); break;
                case 2: PictureDemo(); break;
                case 3: TrackDemo(); break;
                case 4: TimerDemo(); break;
                case 5: ProgressDemo(); break;
                case 6: ComboDemo(); break;
                case 7: MessageDemo(); break;
                case 8: ColorDemo(); break;
                case 9: FileDemo(); break;
                case 10: FontDemo(); break;
                case 11: NonModalDemo(); break;
            }
        }

        // =========================
        // Задание 7: DateTimePicker
        // =========================
        private void DateTimeDemo()
        {
            DateTimePicker dt = new DateTimePicker();
            Label lb = new Label();
            lb.AutoSize = true;

            dt.ValueChanged += (s, e) =>
            {
                lb.Text = dt.Value.ToLongDateString();
            };

            AddControl(dt);
            AddControl(lb);
        }

        // =========================
        // Задание 8: NumericUpDown
        // =========================
        private void NumericDemo()
        {
            // TODO:
            // 1. Создать NumericUpDown num
            // 2. Задать диапазон (например 0–100) Minumum, Maximum
            // 3. Создать Label lb (Autosize=True)
            // 4. Обработать ValueChanged для num с помощью лямбда-выражения (s, e) =>
            // 5. Выводить num.Value в lb
            // 5. Добавить num, label через AddControl()

            // Example:
            // Пользователь увеличивает значение до 42
            // Label показывает:
            // "Значение: 42"
        }

        // =========================
        // Задание 9: PictureBox
        // =========================
        private void PictureDemo()
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Height = 300;

            Button load = new Button();
            load.AutoSize = true;
            load.Text = "Загрузить";

            load.Click += (s, e) =>
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(dlg.FileName);
                }
            };

            AddControl(pb);
            AddControl(load);
        }

        // =========================
        // Задание 10: TrackBar
        // =========================
        private void TrackDemo()
        {
            // TODO:
            // 1. Создать TrackBar track
            // 2. Создать Label label (AutoSize=True)
            // 3. Обработать Scroll для label с помощью лямбда-выражения (s, e) =>
            // 4. Выводить значение track.Value в label
            // 5. Добавить track, label через AddControl()

            // Example:
            // Пользователь передвигает ползунок на 75
            // Label показывает:
            // "Значение: 75"
        }

        // =========================
        // Задание 11: Timer
        // =========================
        private void TimerDemo()
        {
            Label label = new Label();
            label.AutoSize = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                label.Text = DateTime.Now.ToLongTimeString();
            };
            timer.Start();

            AddControl(label);
        }

        // =========================
        // Задание 12: ProgressBar
        // =========================
        private void ProgressDemo()
        {
            // TODO:
            // 1. Создать ProgressBar bar
            // 2. Создать кнопку Button start (AutoSize = true, Text = "Старт")
            // 3. Создать Timer timer (Interval=100)
            // 4. Обработать Tick для timer с помощью лямбда-выражения (s, e) =>
            // 5. Если bar.Value < 100, увеличить bar.Value на 1
            // иначе остановить Timer (stop)
            // 6. Обработать нажатие на кнопку start Click с помощью лямбда-выражения (s, e) =>
            // bar.Value задать равным 0, стартовать timer
            // 7. Добавить bar, start через AddControl()

            // Example:
            // После нажатия кнопки:
            // ProgressBar постепенно заполняется от 0 до 100%
        }

        // =========================
        // Задание 13: ComboBox
        // =========================
        private void ComboDemo()
        {
            ComboBox combo = new ComboBox();
            combo.Items.AddRange(new string[] { "Красный", "Зелёный", "Синий" });
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            Label label = new Label();
            label.AutoSize = true;

            combo.SelectedIndexChanged += (s, e) =>
            {
                if (combo.SelectedItem != null)
                    label.Text = "Выбор: " + combo.SelectedItem.ToString();
            };

            AddControl(combo);
            AddControl(label);
        }

        // =========================
        // Задание 14: MessageBox
        // =========================
        private void MessageDemo()
        {
            // TODO:
            // 1. Создать кнопку show (AutoSize = true)
            // 2. Обработать нажатие на кнопку show Click с помощью лямбда-выражения (s, e) =>
            // 3. Показать MessageBox.Show с текстом "Пример Модального Окна"
            // 4. Добавить show через AddControl()
        }

        // =========================
        // Задание 15: ColorDialog
        // =========================
        private void ColorDemo()
        {
            Button color = new Button();
            color.AutoSize = true;
            color.Text = "Выбрать Цвет";

            color.Click += (s, e) =>
            {
                ColorDialog dlg = new ColorDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    content.BackColor = dlg.Color;
                }
            };

            AddControl(color);
        }

        // =========================
        // Задание 16: OpenFileDialog
        // =========================
        private void FileDemo()
        {
            // TODO:
            // 1. Создать кнопку Button file (AutoSize = true, Text="Открыть Файл")
            // 2. Обработать нажатие на кнопку file Click с помощью лямбда-выражения (s, e) =>
            // 3. Открыть/создать OpenFileDialog dlg
            // 4. Показать MessageBox с текстом dlg.FileName, если dlg.ShowDialog() == DialogResult.OK 
            // 5. Добавить file через AddControl()

            // Example:
            // Пользователь выбирает файл:
            // "C:\\Users\\User\\file.txt"
            // Путь отображается в MessageBox
        }

        // =========================
        // Задание 17: FontDialog
        // =========================
        private void FontDemo()
        {
            Button font = new Button();
            font.AutoSize = true;
            font.Text = "Выбрать Шрифт";

            font.Click += (s, e) =>
            {
                FontDialog dlg = new FontDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Пример текста";
                    label.Font = dlg.Font;
                    AddControl(label);
                }
            };

            AddControl(font);
        }

        // =========================
        // Задание 18: Немодальное окно
        // =========================
        private void NonModalDemo()
        {
            // TODO:
            // 1. Создать кнопку Button form (AutoSize = true, Text="Выбрать Шрифт")
            // 2. Обработать нажатие на кнопку form Click с помощью лямбда-выражения (s, e) =>
            // 3. Создать новую форму Form f (Text="Немодальное Окно")
            // 4. Показать f (Show())
            // 5. Добавить form через AddControl()

            // Example:
            // Открывается новое окно,
            // при этом основное окно остаётся доступным
        }
    }
}


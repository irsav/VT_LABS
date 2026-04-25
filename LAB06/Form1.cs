namespace LAB06
{
    public partial class Form1 : Form
    {
        private Label display;

        // Переменные, необходимые для логики приложения, не меняем.
        private string currentInput = "0";
        private decimal firstNumber = 0;
        private string operation = "";
        private bool newInput = true;

        // ================= 1. Главная форма =================
        public Form1()
        {
            // TODO: 1.0 Собрать и запустить проект

            // TODO: 1.1 Удалить вызов метода InitializeComponent()
            // Вызвать метод InitUI для инициализации интерфейса калькулятора (показать интерфейс)
            InitUI();
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
        }

        private void InitUI()
        {
            // ================= 2. Свойства формы (окна калькулятора) =================
            // TODO: 2.1 Подписать главное окно своим ФИО (Свойство формы Text)
            this.Text = "Мудумаров Владислав Александрович";

            // TODO: 2.2 Задать размер окна = 800x600 (Свойство формы Size)
            this.Size = new Size(800, 600);

            // TODO: 2.3 Задать цвет фона Color.FromArgb(30, 30, 30) (Свойство формы BackColor)
            this.BackColor = Color.FromArgb(30, 30, 30);
            
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)

            // ================= 3. Главный контейнер =================
            TableLayoutPanel main = new TableLayoutPanel();

            // TODO: 3.1 Растянуть контейнера по всей ширине и длине занимаемого родителя (Свойство контейнера Dock/DockStyle.Fill)
            main.Dock = DockStyle.Fill;

            // TODO: 3.2 Задать число строк в контейнере = 2, число столбцов = 1 (Свойства контейнера RowCount, ColumnCount)
            main.RowCount = 2;
            main.ColumnCount = 1;
            // TODO: 3.3 Задать размер первой строки таблицы = точно 120px
            // Свойство RowStyles.Add(new RowStyle(SizeType.Absolute, ...))
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 120f));

            // TODO: 3.4 Задать размер второй строки таблицы = 100 (проценты)
            // Свойство RowStyles.Add(new RowStyle(SizeType.Percent, ...))
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            this.Controls.Add(main);

            // ================= 4. Строка вычислений (дисплей) =================
            Panel displayPanel = new Panel();
            //displayPanel.BorderStyle = BorderStyle.FixedSingle;

            // TODO: 4.1 Растянуть displayPanel по всей ширине и длине занимаемого родителя (Свойство контейнера Dock/DockStyle.Fill)
            displayPanel.Dock = DockStyle.Fill;

            display = new Label();

            // TODO: 4.2 Растянуть display по всей ширине и длине занимаемого контейнера (Свойство контейнера Dock/DockStyle.Fill)
            display.Dock = DockStyle.Fill;

            // TODO: 4.3 Задать display начальный текст = "0" (Свойство Text)
            display.Text = "0";

            // TODO: 4.4 Задать цвет текста display белым (Свойство ForeColor (Color.White))
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            display.ForeColor = Color.White;

            // TODO: 4.5 Задать шрифт текста display ("JetBrains Mono NL", размер = 30) (Свойство Font = new Font(..., ...))
            display.Font = new Font("JetBrains Mono NL", 20);

            // TODO: 4.6 Задать выравнивание текста внутри display по нижней-правой стороне
            // (Свойство TextAligh (ContentAlignment.BottomRight))
            display.TextAlign = ContentAlignment.BottomRight;

            // TODO: 4.7 Задать внутренние display отступы = 10 (Свойство Padding = new Padding(...))
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            display.Padding = new Padding(10);

            displayPanel.Controls.Add(display);
            main.Controls.Add(displayPanel, 0, 0);

            // ================= 5. Контейнер с кнопками =================
            TableLayoutPanel grid = new TableLayoutPanel();
            //grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // TODO: 5.1 Растянуть grid по всей ширине и длине занимаемого родителя (Свойство контейнера Dock/DockStyle.Fill)
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            grid.Dock = DockStyle.Fill;

            // TODO: 5.2 Задать число строк в контейнере кнопок = 6, число столбцов = 4 (Свойства контейнера RowCount, ColumnCount)
            grid.RowCount = 6;
            grid.ColumnCount = 4;

            for (int i = 0; i < 6; i++)
            {
                // TODO: 5.3 Задать размер каждой строки grid контейнера = 100f / 6 (проценты)
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f/6));
                // Свойство RowStyles.Add(new RowStyle(SizeType.Percent, ...))
                // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            }

            for (int j = 0; j < 4; j++)
            {
                // TODO: 5.4 Задать размер каждого столбца grid контейнера = 25 (проценты)
                // Свойство ColumnStyles.Add(new ColumnStyle(SizeType.Percent, ...))
                // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            }

            main.Controls.Add(grid, 0, 1);

            string[,] buttons = {
                { "%", "CE", "C", "⌫" },
                { "1/x", "x²", "√x", "÷" },
                { "7", "8", "9", "×" },
                { "4", "5", "6", "-" },
                { "1", "2", "3", "+" },
                { "+/-", "0", ".", "=" }
            };

            // ================= 6. Создание кнопок =================
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    string text = buttons[r, c];

                    // TODO: 6.1 Создать кнопку (объект Button btn) с помощью метода CreateButton(text)
                    Button btn = CreateButton(text);

                    if (text == "=")
                    {
                        // TODO: 6.2 Если текст текущей кнопки = "=" - задать ей цвет Color.FromArgb(0, 120, 215)
                        // Свойство BackColor
                        btn.BackColor = Color.FromArgb(0, 120, 215);
                    }

                    // TODO: 6.3 Добавить обработчик события нажатия кнопки (метод OnButtonClick)
                    btn.Click += OnButtonClick;

                    // TODO: 6.4 Добавить кнопки в сетку grid (Раскоментировать строку ниже)
                    // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)

                    
                    grid.Controls.Add(btn, c, r);
                }
            }
        }

        private Button CreateButton(string text)
        {
            Button btn = new Button();

            // TODO: 6.5 Текст кнопки = аргументу метода CreateButton (Свойство Text)
            btn.Text = text;

            // TODO: 6.6 Растянуть кнопку по размеру ячейки таблицы (Свойство Кнопки Dock/DockStyle.Fill)
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            btn.Dock = DockStyle.Fill;

            // TODO: 6.7 Задать шрифт текста ("JetBrains Mono NL", размер = 14) (Свойство Font)
            btn.Font = new Font("JetBrains Mono NL", 14);


            // TODO: 6.8 Задать цвет фона Color.FromArgb(50, 50, 50) (Свойство BackColor)
            btn.BackColor = Color.FromArgb(50, 50, 50);
            // TODO: 6.9 Задать цвет шрифта Color.White (Свойство ForeColor)
            btn.ForeColor = Color.White;
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)

            // TODO: 6.10 Сделать кнопки плоскими Свойство FlatStyle (FlatStyle.Flat)
            // и убрать границы Свойство FlatAppearance.BorderSize (0)
            // (ЗАПУСТИТЬ ПРОЕКТ - СДЕЛАТЬ СКРИНШОТ)
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            return btn;
        }

        // ===== 7. ОБРАБОТКА НАЖАТИЙ =====

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string text = btn.Text;

            // ===== СПЕЦИАЛЬНЫЕ КНОПКИ =====
            if (text == "C" || text == "CE")
            {
                // TODO: 7.1 Вызвать метод Clear
                Clear();
            }
            else if (text == "⌫")
            {
                // TODO: 7.2 Вызвать метод Backspace
                Backspace();
            }

            else if (text == "+/-")
            {
                // TODO: 7.3 Вызвать метод ToggleSign
                ToggleSign();
            }
            else if (text == "=")
            {
                // 7.4 Вызвать метод Calculate
                Calculate();
            }
            else if (text == "%")
            {
                // TODO: 7.5 Вызвать метод Percent
                Percent();
            }

            else if (text == "1/x")
            {
                // TODO: 7.6 Вызвать метод Inverse
                Inverse();
            }
            else if (text == "x²")
            {
                // TODO: 7.7 Вызвать метод Square
                Square();
            }
            else if (text == "√x")
            {
                // TODO: 7.8 Вызвать метод Sqrt
                Sqrt();
            }

            // ===== ВВОД =====
            else if (char.IsDigit(text, 0))
            {
                // TODO: 7.9 Вызвать метод AddDigit
                AddDigit(text);
            }
            else if (text == ".")
            {
                // TODO: 7.10 Вызвать метод AddDot
                AddDot();
            }

            // ===== ОПЕРАЦИИ =====
            else if (text == "+" || text == "-" || text == "×" || text == "÷")
            {
                // TODO: 7.11 Вызвать метод SetOperaton
                SetOperation(text);
            }
        }

        // ===== 8. Методы нажатий =====

        private void UpdateDisplay()
        {
            // TODO: 8.1 Задать текст внутри контейнера display = currentInput (Свойство Text)
            display.Text = currentInput;
        }

        private void AddDigit(string digit)
        {
            if (newInput)
            {
                currentInput = digit;
                newInput = false;
            }
            else
            {
                if (currentInput == "0")
                    currentInput = digit;
                else
                    currentInput += digit;
            }

            // TODO: 8.2 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКИ ЦИФР - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void AddDot()
        {
            if (newInput)
            {
                currentInput = "0.";
                newInput = false;
            }
            else if (!currentInput.Contains("."))
            {
                currentInput += ",";
            }

            // TODO: 8.3 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ ТОЧКИ - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void SetOperation(string op)
        {
            firstNumber = decimal.Parse(currentInput);
            operation = op;
            newInput = true;
        }

        private void Calculate()
        {
            try
            {
                decimal secondNumber = decimal.Parse(currentInput);
                decimal result = 0;

                switch (operation)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "×": result = firstNumber * secondNumber; break;
                    case "÷":
                        if (secondNumber == 0)
                            throw new DivideByZeroException();
                        result = firstNumber / secondNumber;
                        break;
                }

                currentInput = result.ToString("G29");
                newInput = true;
                // TODO: 8.4 Вызвать метод UpdateDisplay
                // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ ПРОВЕСТИ ОПЕРАЦИИ МЕЖДУ 2 ЧИСЛАМИ - СДЕЛАТЬ СКРИНШОТ)
                UpdateDisplay();
            }
            catch (OverflowException)
            {
                ShowError("Overflow");
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero");
            }
            catch
            {
                ShowError("Error");
            }
        }

        private void Clear()
        {
            currentInput = "0";
            firstNumber = 0;
            operation = "";
            newInput = true;

            // TODO: 8.5 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКИ CE, C - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void Backspace()
        {
            if (!newInput && currentInput.Length > 1)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }
            else
            {
                currentInput = "0";
                newInput = true;
            }

            // TODO: 8.6 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ ⌫ - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void ToggleSign()
        {
            if (currentInput != "0")
            {
                if (currentInput.StartsWith("-"))
                    currentInput = currentInput.Substring(1);
                else
                    currentInput = "-" + currentInput;
            }

            // TODO: 8.7 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ +- - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void Percent()
        {
            decimal value = decimal.Parse(currentInput);
            currentInput = (value / 100).ToString();

            // TODO: 8.8 Вызвать метод UpdateDisplay
            // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ % - СДЕЛАТЬ СКРИНШОТ)
            UpdateDisplay();
        }

        private void Inverse()
        {
            try
            {
                decimal value = decimal.Parse(currentInput);

                if (value == 0)
                    throw new DivideByZeroException();

                decimal result = 1m / value;

                currentInput = result.ToString("G29");
                newInput = true;

                // TODO: 8.9 Вызвать метод UpdateDisplay
                // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ 1/x - СДЕЛАТЬ СКРИНШОТ)
                UpdateDisplay();
            }
            catch (OverflowException)
            {
                ShowError("Overflow");
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero");
            }
        }

        private void Square()
        {
            try
            {
                decimal value = decimal.Parse(currentInput);
                decimal result = value * value;

                currentInput = result.ToString("G29");
                newInput = true;

                // TODO: 8.10 Вызвать метод UpdateDisplay
                // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ x² - СДЕЛАТЬ СКРИНШОТ)
                UpdateDisplay();
            }
            catch (OverflowException)
            {
                ShowError("Overflow");
            }
        }

        private void Sqrt()
        {
            try
            {
                decimal value = decimal.Parse(currentInput);

                if (value < 0)
                    throw new Exception();

                double result = Math.Sqrt((double)value);

                currentInput = ((decimal)result).ToString("G29");
                newInput = true;

                // TODO: 8.11 Вызвать метод UpdateDisplay
                // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ НАЖАТЬ НА КНОПКУ √x - СДЕЛАТЬ СКРИНШОТ)
                UpdateDisplay();
            }
            catch
            {
                ShowError("Error");
            }
        }

        private void ShowError(string message)
        {
            // TODO: 8.12 // (ЗАПУСТИТЬ ПРОЕКТ - ПОПРОБАВАТЬ ПОДЕЛИТЬ НА 0 ИЛИ МНОГО РАЗ ВОЗВЕСТИ В КВАДРАТ - СДЕЛАТЬ СКРИНШОТ)
            display.Text = message;
            currentInput = "0";
            newInput = true;
        }
    }
}

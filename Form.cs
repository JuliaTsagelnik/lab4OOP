using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircleMovementApp
{
    public class CircleForm : Form
    {
        private readonly Circle circle;
        private readonly DrawingPanel drawingPanel;
        private readonly Button btnUp, btnDown, btnLeft, btnRight;

        public CircleForm()
        {
            // Инициализация круга
            circle = new Circle(100, 100, 20, 10);

            // Свойства формы
            this.Text = "Приложение для перемещения круга";
            this.Size = new Size(400, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Инициализация панели для рисования
            drawingPanel = new DrawingPanel(circle)
            {
                Location = new Point(10, 10),
                Size = new Size(360, 200)
            };
            this.Controls.Add(drawingPanel);

            // Инициализация кнопок
            btnUp = new Button
            {
                Text = "Вверх",
                Location = new Point(10, 220),
                Size = new Size(80, 30)
            };
            btnDown = new Button
            {
                Text = "Вниз",
                Location = new Point(100, 220),
                Size = new Size(80, 30)
            };
            btnLeft = new Button
            {
                Text = "Влево",
                Location = new Point(190, 220),
                Size = new Size(80, 30)
            };
            btnRight = new Button
            {
                Text = "Вправо",
                Location = new Point(280, 220),
                Size = new Size(80, 30)
            };

            // Добавление кнопок на форму
            this.Controls.Add(btnUp);
            this.Controls.Add(btnDown);
            this.Controls.Add(btnLeft);
            this.Controls.Add(btnRight);

            // Обработчики событий для кнопок
            // Использование методов с делегатами для кнопок Вверх и Вниз
            btnUp.Click += new EventHandler(MoveUp);
            btnDown.Click += new EventHandler(MoveDown);

            // Использование лямбда-выражений для кнопок Влево и Вправо
            btnLeft.Click += (s, e) =>
            {
                circle.MoveLeft();
                drawingPanel.Redraw();
            };
            btnRight.Click += (s, e) =>
            {
                circle.MoveRight(drawingPanel.Width);
                drawingPanel.Redraw();
            };
        }

        private void MoveUp(object sender, EventArgs e)
        {
            circle.MoveUp(drawingPanel.Height);
            drawingPanel.Redraw();
        }

        private void MoveDown(object sender, EventArgs e)
        {
            circle.MoveDown(drawingPanel.Height);
            drawingPanel.Redraw();
        }
    }
}
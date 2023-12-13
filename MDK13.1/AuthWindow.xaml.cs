using MDK13._1;
using System;
using System.Windows;

namespace MDK13
{
    /// <summary>
    /// Окно автори
    /// </summary>
    public partial class AuthWindow : Window
    {
        public bool IsAuthorized { get; private set; } = false;
        private const string password = "123";

        /// <summary>
        /// Конструктор
        /// </summary>
        public AuthWindow() => InitializeComponent();

        /// <summary>
        /// Обработчик события активации окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowActivation(object sender, EventArgs e) => passwordInput.Focus();

        /// <summary>
        /// Обработчик события нажатия на кнопку Войти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (passwordInput.Password == password) {
                IsAuthorized = true;
                Close();
            }
            else
            {
                MessageBox.Show("Пароль неверен. Повторите ввод");
                passwordInput.Focus();
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();

        /// <summary>
        /// Обработчик события закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsAuthorized != true)
            {
                MessageBoxResult result = MessageBox.Show("Вы желаете завершить работу с программой?", "Выход изпрограммы", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.No)
                    e.Cancel = true;
                else
                    Application.Current.Shutdown();
            }
            else
            {
                MainWindow w = new();
                w.Show();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Presenter.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CinemaFormButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр ICinemaPresenter
            ICinemaPresenter cinemaPresenter = new CinemaPresenter(); // Убедитесь, что CinemaPresenter реализует ICinemaPresenter

            // Создаем форму CinemaForm и передаем cinemaPresenter
            CinemaForm cinemaForm = new CinemaForm(cinemaPresenter);

            // Показываем форму
            cinemaForm.Show();
        }

        private void FilmFormButton_Click(object sender, EventArgs e)
        {
            // Здесь можно создать и передать Presenter для FilmForm
        }

        private void SuppliersFormButton_Click(object sender, EventArgs e)
        {
            // Здесь можно создать и передать Presenter для SuppliersForm
        }

        private void PurchaseFormButton_Click(object sender, EventArgs e)
        {
            // Здесь можно создать и передать Presenter для PurchaseForm
        }

        private void RentalFormButton_Click(object sender, EventArgs e)
        {
            // Здесь можно создать и передать Presenter для RentalForm
        }
    }
}

using System;
using System.Windows.Forms;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Presenter.Classes;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Services.Classes;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Repositories.Classes;

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
            ICinemaRepository repository = new CinemaRepository();
            ICinemaService service = new CinemaService(repository);
            // Создаем экземпляр ICinemaPresenter
            ICinemaPresenter cinemaPresenter = new CinemaPresenter(service); // Убедитесь, что CinemaPresenter реализует ICinemaPresenter

            // Создаем форму CinemaForm и передаем cinemaPresenter
            CinemaForm cinemaForm = new CinemaForm(cinemaPresenter);

            // Показываем форму
            cinemaForm.Show();
        }

        private void FilmFormButton_Click(object sender, EventArgs e)
        {
            IFilmsRepository repository = new FilmsRepository();
            IFilmsService service = new FilmsService(repository);
            // Создаем экземпляр ICinemaPresenter
            IFilmsPresenter filmPresenter = new FilmsPresenter(service); // Убедитесь, что CinemaPresenter реализует ICinemaPresenter

            // Создаем форму CinemaForm и передаем cinemaPresenter
            FilmForm filmForm = new FilmForm(filmPresenter);

            // Показываем форму
            filmForm.Show();
        }

        private void SuppliersFormButton_Click(object sender, EventArgs e)
        {
            ISupplierRepository repository = new SupplierRepository();
            ISupplierService service = new SupplierService(repository);
            // Создаем экземпляр ICinemaPresenter
            ISupplierPresenter supplierPresenter = new SupplierPresenter(service); // Убедитесь, что CinemaPresenter реализует ICinemaPresenter

            // Создаем форму CinemaForm и передаем cinemaPresenter
            SupplierForm supplierForm = new SupplierForm(supplierPresenter);

            // Показываем форму
            supplierForm.Show();
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

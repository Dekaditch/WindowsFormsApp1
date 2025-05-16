using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Services.Interfaces;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApp1.DTOs;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Forms
{
    public partial class SupplierForm : Form, ISupplierView
    {
        public SupplierForm(ISupplierPresenter supplierPresenter)
        {
            InitializeComponent();
            buttonUpdate.Enabled = false;
            _supplierPresenter = supplierPresenter;
            LoadSuppliers();
        }
        private readonly ISupplierPresenter _supplierPresenter;
        private readonly ISupplierService _supplierService;
        private const string jsonFilePath = "suppliers.json";
        private void LoadSuppliers() 
        {
            var suppliers = _supplierPresenter.GetAllSupplier();
            dataGridView1.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                AddSupplierToList(supplier);
            }
        }
        public string Name { get => textName.Text; set => textName.Text = value; }
        public string LegalAddress { get => textLegalAddress.Text; set => textLegalAddress.Text = value; }
        public string SupplierBank { get => textSBank.Text; set => textSBank.Text = value; }
        public string SupplierBankNumber { get => textSBankNumber.Text; set => textSBankNumber.Text = value; }
        public string SupplierITN { get =>  textSITN.Text; set => textSITN.Text = value; }
        public void ShowMessage(string message) 
        {
            MessageBox.Show(message);
        }
        public void ClearFields() 
        {
            textName.Clear();
            textLegalAddress.Clear();
            textSBank.Clear();
            textSBankNumber.Clear();
            textSITN.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var supplierDTO = new SupplierDTO
            {
                Name = Name,
                LegalAddress = LegalAddress,
                SupplierBank = SupplierBank,
                SupplierBankNumber = SupplierBankNumber,
                SupplierITN = SupplierITN
            };
            _supplierPresenter.AddSupplier(supplierDTO);
            ClearFields();
            SaveSupplierToJson();
        }
        private void SaveSupplierToJson() 
        {
            var suppliers = _supplierPresenter.GetAllSupplier();
            var json = JsonConvert.SerializeObject(suppliers, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            ShowMessage("Данные сохранены");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ClearSupplierList();
        }

        public void AddSupplierToList(SupplierDTO supplier)
        {
            dataGridView1.Rows.Add(supplier.Name, supplier.LegalAddress, supplier.SupplierBank, supplier.SupplierBankNumber, supplier.SupplierITN);
            
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var objectEntity = _supplierService.GetSupplierByITN(textSITN.Text);
            if (objectEntity == null)
            {
                ShowMessage("Поставщик с данным ИНН не был найден.");
                return;
            }
            var supplierDTO = new SupplierDTO{Name = Name,
                LegalAddress = LegalAddress,
                SupplierBank = SupplierBank,
                SupplierBankNumber = SupplierBankNumber,
                SupplierITN = SupplierITN};
            _supplierPresenter.UpdateSupplier(supplierDTO);
        }

        public void ClearSupplierList()
        {
            _supplierPresenter.RemoveSupplier(Name);
            ClearFields();
            SaveSupplierToJson();
        }



    }
}

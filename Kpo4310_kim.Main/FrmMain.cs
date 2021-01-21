using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4310.kim.Lib;
using Kpo4310.Lib;

namespace Kpo4310.kim.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            label1.Text = "Файл для журнала: " + AppGlobalSettings.logPath + "   Файл для данных: " + AppGlobalSettings.dataFileName;
        }

        private List<Accessory> accessoryList = new List<Accessory>();
        private BindingSource bsAccessory = new BindingSource();

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // throw new NotImplementedException(); //Исключение "Метод не реализован"
                // throw new Exception("Неправильные входные параметры!"); //Базовое исключение

                // MockAccessoryListCommand loader = new MockAccessoryListCommand();

                // LoadAccessoryListCommand loader = new LoadAccessoryListCommand(AppGlobalSettings.dataFileName);

                //IAccessoryListLoader loader = new AccessoryListSplitFileLoader(AppGlobalSettings.dataFileName);

                // IAccessoryListLoader loader = new AccessoryListTestLoader();

                IAccessoryListLoader Loader = AppGlobalSettings.accessoryFactory.CreateAccessoryListLoader();

                Loader.Execute();

                // dgvAccessory.DataSource = loader.accessoryList;

                accessoryList = Loader.accessoryList;
                bsAccessory.DataSource = accessoryList;
                dgvMockAccessoryListCommand.DataSource = bsAccessory;
            }
            catch (NotImplementedException ex) //Обработка "Метод не реализован"
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            catch (Exception ex) //Обработка остальных исключений
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }

        private void mnOpenAccessory_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccessory frmAccessory = new FrmAccessory();

                Accessory accessory = (bsAccessory.Current as Accessory);
                frmAccessory.SetAccessory(accessory);

                frmAccessory.ShowDialog();
            }
            catch (NotImplementedException ex) //Обработка "Метод не реализован"
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            catch (Exception ex) //Обработка остальных исключений
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (accessoryList == null || accessoryList.Count == 0)
                    throw new Exception("Сохранение невохможно, таблица пуста");

                IAccessoryListSaver Saver = AppGlobalSettings.accessoryFactory.CreateAccessoryListSaver();
                Saver.accessoryList = accessoryList;
                Saver.Execute();
            }
            catch (NotImplementedException ex) //Обработка "Метод не реализован"
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            catch (Exception ex) //Обработка остальных исключений
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }
    }
}

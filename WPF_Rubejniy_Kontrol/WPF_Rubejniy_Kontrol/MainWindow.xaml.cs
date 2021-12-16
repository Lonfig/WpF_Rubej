using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Rubejniy_Kontrol
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Salon> salonList = new List<Salon>();

        public MainWindow()
        {
            InitializeComponent();
            initDataGrid();
        }
        public void initDataGrid()
        {
            initData();
           //Добавляем данные из списка в DataGrid
            dataGrid.ItemsSource = salonList;
        }
        public void initData()
        {
            //Заполняем данные в лист
            salonList.Add(new Salon()
            {
                Name = "Наращивание ресниц",
                Duration = "40мин",
                Price= 1430,
                Sale = 5
            });
            salonList.Add(new Salon()
            {
                Name = "Моделирование ресниц+тушь",
                Duration = "2100сек",
                Price = 1390,
                Sale = 10
            });
            salonList.Add(new Salon()
            {
                Name = "Ламинирование ресниц",
                Duration = "3300сек",
                Price = 1740,
                Sale = 25
            });
            salonList.Add(new Salon()
            {
                Name = "Русский спа массаж",
                Duration = "50мин",
                Price = 2540,
                Sale = 20
            });
            salonList.Add(new Salon()
            {
                Name = "Мезотерапия",
                Duration = "40мин",
                Price = 2040,
                Sale = 20
            });
            salonList.Add(new Salon()
            {
                Name = "Полуперманентная тушь",
                Duration = "1800сек",
                Price = 2340,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Экспресс SPA",
                Duration = "15мин",
                Price = 2420,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Пирсинг",
                Duration = "55мин",
                Price = 1330,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Массаж масляный",
                Duration = "3000сек",
                Price = 1090,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Прессотерапия",
                Duration = "2400сек",
                Price = 2350,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Европейский маникюр",
                Duration = "3600сек",
                Price = 1990,
                Sale = 5
            });
            salonList.Add(new Salon()
            {
                Name = "Удаление доброкачественных образований кожи",
                Duration = "900сек",
                Price = 1910,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Испанский массаж",
                Duration = "2400сек",
                Price = 2190,
                Sale = 25
            });
            salonList.Add(new Salon()
            {
                Name = "Наращивание ресниц кукольного эффекта",
                Duration = "2100сек",
                Price = 2120,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Стрижка с покраской",
                Duration = "1500сек",
                Price = 2300,
                Sale = 10
            });
            salonList.Add(new Salon()
            {
                Name = "Детокс спа",
                Duration = "30мин",
                Price = 1330,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Стоун-терапия",
                Duration = "3000сек",
                Price = 2100,
                Sale = 25
            });
            salonList.Add(new Salon()
            {
                Name = "Радиоволновой лифтинг",
                Duration = "50мин",
                Price = 1590,
                Sale = 15
            });
            salonList.Add(new Salon()
            {
                Name = "Химические завивки",
                Duration = "50мин",
                Price = 1090,
                Sale = 20
            });
            salonList.Add(new Salon()
            {
                Name = "Альгинатные маски",
                Duration = "3300сек",
                Price = 2370,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Спортивный массаж",
                Duration = "1800сек",
                Price = 1650,
                Sale = 15
            });
            salonList.Add(new Salon()
            {
                Name = "Лечебное покрытие ногтей",
                Duration = "1800сек",
                Price = 1220,
                Sale = 15
            });
            salonList.Add(new Salon()
            {
                Name = "Реконструкция и лечение волос и кожи головы",
                Duration = "55мин",
                Price = 2360,
                Sale = 20
            });
            salonList.Add(new Salon()
            {
                Name = "Классический маникюр",
                Duration = "3300сек",
                Price = 1680,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Консультация врача",
                Duration = "1800сек",
                Price = 2120,
                Sale = 25
            });
            salonList.Add(new Salon()
            {
                Name = "Наращивание ресниц лисьего эффекта",
                Duration = "1800сек",
                Price = 1370,
                Sale = 20
            });
            salonList.Add(new Salon()
            {
                Name = "Экспресс-педикюр",
                Duration = "1200сек",
                Price = 2170,
                Sale = 15
            });
            salonList.Add(new Salon()
            {
                Name = "Гречишный массаж",
                Duration = "2400сек",
                Price = 1520,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Комбинированный маникюр",
                Duration = "60мин",
                Price = 2390,
                Sale = 0
            });
            salonList.Add(new Salon()
            {
                Name = "Фонофорез лица",
                Duration = "1200сек",
                Price = 1120,
                Sale = 5
            });

        }

        
        private void sortList(int type)
        {
            //Сортировка
            switch(type)
            {
                //По возрастанию
                case 0:
                    var sortListPrice1 = new List<Salon>();
                    sortListPrice1.AddRange(salonList);
                    sortListPrice1.Sort(delegate (Salon x, Salon y)
                    {
                        if (x.Price > y.Price) return 1;
                        else return -1;
                    });
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = sortListPrice1;
                    break;
                //По убыванию
                case 1:
                    var sortListPrice2 = new List<Salon>();
                    sortListPrice2.AddRange(salonList);
                    sortListPrice2.Sort(delegate (Salon x, Salon y)
                    {
                        if (x.Price < y.Price) return 1;
                        else return -1;
                    });
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = sortListPrice2;
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            filterList(filterComboBox.SelectedIndex);
        }
        private void filterList(int type)
        {
            //Фильтрация
            switch(type)
            {
                //По цене
                case 0:
                    List<Salon> filterListPrice = new List<Salon>();
                    foreach(Salon item in salonList)
                    {
                        if(item.Price>=Convert.ToInt32(fromTexBox.Text)&& item.Price <= Convert.ToInt32(toTexBox.Text))
                        {
                            filterListPrice.Add(item);
                        }
                    }
                    dataGrid.ItemsSource = filterListPrice;
                    break;
                //По скидке
                case 1:
                    List<Salon> filterListSale = new List<Salon>();
                    foreach (Salon item in salonList)
                    {
                        if (item.Sale >= Convert.ToInt32(fromTexBox.Text) && item.Sale <= Convert.ToInt32(toTexBox.Text))
                        {
                            filterListSale.Add(item);
                        }
                    }
                    dataGrid.ItemsSource = filterListSale;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Сброс 
            dataGrid.ItemsSource = salonList;
        }

        private void sortBtn_Click_1(object sender, RoutedEventArgs e)
        {
            sortList(sortComboBox.SelectedIndex);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

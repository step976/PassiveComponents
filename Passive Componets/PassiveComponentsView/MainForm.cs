using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Forms;
using PassiveComponentsView.Tools;
using Passive_Componets;


namespace PassiveComponentsView
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Элемент класса Project.
        /// </summary>
        private ElementsProject _elementsProject;

        /// <summary>
        /// Переменная для имени файла.
        /// </summary>
        private string _fileName = "C:\\Users\\User\\Documents\\New List spg";

        /// <summary>
        /// Сериализует и десериализует файлы.
        /// </summary>
        private readonly Serialization _serializeElement = new Serialization();

        #region Methods

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            var elements = new List<IElement>();
            _elementsProject = new ElementsProject
            {
                Elements = elements,
                AngularFrequency = Convert.ToDouble(AngularFreqTextBox.Text),
                FileName = _fileName
            };
            EnableButtonInMainForm(false);
#if !DEBUG
            AutoCreateButton.Visible = false;
#endif
        }

        /// <summary>
        /// Активация кнопок.
        /// </summary>
        /// <param name="i"></param>
        private void EnableButtonInMainForm(bool i)
        {
            AddElementButton.Enabled = i;
            ModifyElementButton.Enabled = i;
            RemoveElementButton.Enabled = i;
            CalculateGroupBox.Enabled = i;
            SearchGroupBox.Enabled = i;
            SearchButton.Enabled = i;
            SearchTextBox.Enabled = i;
            CalculateButton.Enabled = i;
            AngularFreqTextBox.Enabled = i;
            AutoCreateButton.Enabled = i;
        }

        /// <summary>
        /// Если произошло изменение в файлах.
        /// </summary>
        /// <param name="i"></param>
        private void WasChange(bool i)
        {
            if (i)
            {
                Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @"* - Spengle";
            }
            else
            {
                if (_fileName != null)
                {
                    Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - Spengle";
                }
                else
                {
                    Text = @"Passive Components - Spengle";
                }
            }
        }

        #endregion

        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElement_Click(object sender, EventArgs e)
        {
            if (AngularFreqTextBox.TextLength == 0)
            {
                MessageBox.Show(@"Необходимо ввести угловую частоту", @"Ошибка!");
                return;
            }
            double angularFrequency = Convert.ToDouble(AngularFreqTextBox.Text);
            if (angularFrequency != 0)
            {
                var form = new AddForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var element = form.Element;
                    if (element == null)
                    {
                        return;
                    }
                    _elementsProject.Elements.Add(form.Element);
                    if (element is Resistor)
                    {
                        ElementDataGridView.Rows.Add(element.Name, element.Value,
                            element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                    }
                    if (element is Inductor)
                    {
                        ElementDataGridView.Rows.Add(element.Name, element.Value,
                            element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                    }
                    if (element is Capacitor)
                    {
                        ElementDataGridView.Rows.Add(element.Name, element.Value,
                            element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                    }
                }
                WasChange(true);
            }
        }

        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveElement_Click(object sender, EventArgs e)
        {
            if (_elementsProject.Elements.Count == 0)
            {
                return;
            }
            var resultRemove = MessageBox.Show(@"Вы уверены что хотите удалить элемент(ы)?", @"Удалить",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (resultRemove)
            {
                case DialogResult.Yes:
                {
                    int index = ElementDataGridView.SelectedCells[0].RowIndex;
                    ElementDataGridView.Rows.RemoveAt(index);
                    _elementsProject.Elements.RemoveAt(index);
                    WasChange(true);
                    break;
                }
                case DialogResult.No:
                {
                    return;
                }
            }

        }

        /// <summary>
        /// Пересчет угловой частоты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (AngularFreqTextBox.TextLength == 0)
            {
                MessageBox.Show(@"Введите угловую частоту");
                return;
            }
            try
            {
                var freq = Convert.ToDouble(AngularFreqTextBox.Text);

                for (int i = 0; i < _elementsProject.Elements.Count; i++)
                {
                    ElementDataGridView.Rows[i].Cells["Impedance"].Value =
                        _elementsProject.Elements[i].GetImpedance(freq);
                }
                WasChange(true);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Неверный формат частоты");
            }
        }

        /// <summary>
        /// Изменение элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyElement_Click(object sender, EventArgs e)
        {
            if (_elementsProject.Elements.Count == 0)
            {
                MessageBox.Show(@"Вы не выбрали строки для изменения", @"Ошибка!");
                return;
            }
            int index = ElementDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm
            {
                Element = _elementsProject.Elements[index]
            };
            form.ShowDialog();
            _elementsProject.Elements.RemoveAt(index);
            _elementsProject.Elements.Insert(index, form.Element);
            ElementDataGridView.Rows.RemoveAt(index);
            if (form.Element is Resistor)
            {
                ElementDataGridView.Rows.Insert(index, form.Element.Name, form.Element.Value,
                    form.Element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
            }
            if (form.Element is Inductor)
            {
                ElementDataGridView.Rows.Insert(index, form.Element.Name, form.Element.Value,
                    form.Element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
            }
            if (form.Element is Capacitor)
            {
                ElementDataGridView.Rows.Insert(index, form.Element.Name, form.Element.Value,
                    form.Element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
            }
            WasChange(true);
        }

        /// <summary>
        /// Сохранить из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_elementsProject.Elements.Count != 0)
            {
                _serializeElement.Serialize(_elementsProject);
                _elementsProject.AngularFrequency = Convert.ToDouble(AngularFreqTextBox.Text);
                _elementsProject.FileName = _fileName;
                WasChange(false);
            }
            else
            {
                MessageBox.Show(@"Файл не може быть пустым", @"Ошибка!");
            }
        }

        /// <summary>
        /// Открыть из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {Filter = @"spg files (*.spg)|*.spg"};
            if (dialog.FileName != null)
                try
                {
                    var elementsProject = _serializeElement.Deserialize();
                    if (_elementsProject == null)
                    {
                        return;
                    }
                    _elementsProject.Elements.Clear();
                    ElementDataGridView.Rows.Clear();
                    _elementsProject = elementsProject;

                    AngularFreqTextBox.Text = _elementsProject.AngularFrequency.ToString(CultureInfo.InvariantCulture);
                    _fileName = _elementsProject.FileName;
                    Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - Spengle";

                    foreach (var i in _elementsProject.Elements)
                    {
                        ElementDataGridView.Rows.Add(i.Name, i.Value,
                            i.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show(@"Ошибка файла.", @"Ошибка!");
                }
            EnableButtonInMainForm(true);
            WasChange(false);
        }
        /// <summary>
        /// Рандомные элементы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newRandomElements = RandomElements.CreateRandomElement();
                _elementsProject.Elements.Add(newRandomElements);

                if (newRandomElements is Resistor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameResistor();
                    ElementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                        newRandomElements.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                }
                if (newRandomElements is Inductor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameInductor();
                    ElementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                        newRandomElements.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                }
                if (newRandomElements is Capacitor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameCapacitor();
                    ElementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                        newRandomElements.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Угловая частота не может быть 0.", @"Ошибка!");
            }
            WasChange(true);
        }
        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                for (var i = 0; i < ElementDataGridView.RowCount; i++)
                {
                    ElementDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < ElementDataGridView.ColumnCount; j++)
                    {
                        if (ElementDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        if (!ElementDataGridView.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                        {
                            continue;
                        }
                        ElementDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска", @"Ошибка!");
            }
        }
        /// <summary>
        /// Новый список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_elementsProject.Elements.Count == 0)
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = @"spg files (*.spg)|*.spg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveFileDialog.FileName;
                    Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - Spengle";
                    EnableButtonInMainForm(true);
                }
                else
                {
                    return;
                }
                return;

            }
            var resultNewElement = MessageBox.Show(@"Выхотите сохранить этот файл?", @"Новый файл",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (resultNewElement)
            {
                case DialogResult.Yes:
                {
                    _elementsProject.AngularFrequency = Convert.ToDouble(AngularFreqTextBox.Text);
                    _elementsProject.FileName = _fileName;
                    _serializeElement.Serialize(_elementsProject);
                    _elementsProject.Elements.Clear();
                    ElementDataGridView.Rows.Clear();
                    AngularFreqTextBox.Text = "";
                    _fileName = "C:\\Users\\User\\Documents\\New List";
                        EnableButtonInMainForm(true);
                        break;
                }
                case DialogResult.No:
                {

                    _elementsProject.Elements.Clear();
                    ElementDataGridView.Rows.Clear();
                    AngularFreqTextBox.Text = "";
                    _fileName = "C:\\Users\\User\\Documents\\New List";
                    break;
                }
                case DialogResult.Abort:
                {
                    break;
                }
            }
            WasChange(false);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Сохранить как 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = @"spg files (*.spg)|*.spg",
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = saveFileDialog.FileName;
                Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - Spengle";
            }
            else
            {
                MessageBox.Show(@"Пустой файл.", @"Ошибка!");
            }
            _elementsProject.AngularFrequency = Convert.ToDouble(AngularFreqTextBox.Text);
            _elementsProject.FileName = _fileName;
            _serializeElement.Serialize(_elementsProject);
            WasChange(false);
        }
        /// <summary>
        /// При закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_elementsProject.Elements.Count != 0)
            {
                var dialogResult = MessageBox.Show(@"Сохранить изменения?", @"Предупреждение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                    {
                        _elementsProject.AngularFrequency = Convert.ToDouble(AngularFreqTextBox.Text);
                        _elementsProject.FileName = _fileName;
                        _serializeElement.Serialize(_elementsProject);
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }
    }
}
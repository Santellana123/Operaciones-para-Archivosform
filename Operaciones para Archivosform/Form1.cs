using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Operaciones_para_Archivosform
{
    public partial class Form1 : Form
    {
        // Ruta del archivo
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                filePath = openFileDialog.FileName;

                // Limpiar ListView antes de mostrar nuevo contenido
                listViewArchivo.Items.Clear();

                // Leer el contenido del archivo y mostrarlo en el ListView
                if (Path.GetExtension(filePath) == ".txt")
                {
                    // Leer archivos de texto
                    ReadTextFile(filePath);
                }
                else if (Path.GetExtension(filePath) == ".idx")
                {
                    // Leer archivos secuenciales indexados
                    ReadIndexedSequentialFile(filePath);
                }
                else if (Path.GetExtension(filePath) == ".dat")
                {
                    // Leer archivos de acceso directo
                    ReadDirectAccessFile(filePath);
                }
                else
                {
                    MessageBox.Show("Formato de archivo no compatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para leer archivos de texto
        private void ReadTextFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listViewArchivo.Items.Add(line);
                }
            }
        }

        // Método para leer archivos secuenciales indexados
        private void ReadIndexedSequentialFile(string filePath)
        {
            // Implementar la lógica para leer archivos secuenciales indexados
            MessageBox.Show("Leyendo archivo secuencial indexado...");
        }

        // Método para leer archivos de acceso directo
        private void ReadDirectAccessFile(string filePath)
        {
            // Implementar la lógica para leer archivos de acceso directo
            MessageBox.Show("Leyendo archivo de acceso directo...");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para que el usuario seleccione el tipo de archivo a crear
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt|Archivo secuencial indexado (*.idx)|*.idx|Archivo de acceso directo (*.dat)|*.dat";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta donde se guardará el nuevo archivo
                    filePath = saveFileDialog.FileName;

                    // Crear el archivo si no existe y escribir una línea en blanco para asegurarte de que se cree correctamente
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(""); // Escribir una línea en blanco
                    }

                    // Limpiar ListView
                    listViewArchivo.Items.Clear();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (ListViewItem item in listViewArchivo.Items)
                    {
                        sw.WriteLine(item.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna ruta para guardar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en el ListView
            if (listViewArchivo.SelectedItems.Count > 0)
            {
                // Obtener el índice del elemento seleccionado
                int selectedIndex = listViewArchivo.SelectedIndices[0];

                // Mostrar un cuadro de diálogo para que el usuario modifique el elemento seleccionado
                string modifiedItem = Interaction.InputBox("Ingrese el nuevo valor:", "Modificar Elemento", listViewArchivo.SelectedItems[0].Text);

                // Actualizar el valor en el ListView
                if (!string.IsNullOrEmpty(modifiedItem))
                {
                    listViewArchivo.Items[selectedIndex].Text = modifiedItem;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en el ListView
            if (listViewArchivo.SelectedItems.Count > 0)
            {
                // Eliminar el elemento seleccionado del ListView
                listViewArchivo.Items.RemoveAt(listViewArchivo.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string nuevoItem = textEscribir.Text;

            // Verificar si el texto no está vacío
            if (!string.IsNullOrEmpty(nuevoItem))
            {
                // Agregar el nuevo elemento al ListView
                listViewArchivo.Items.Add(nuevoItem);

                // Limpiar el TextBox después de agregar el elemento
                textEscribir.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
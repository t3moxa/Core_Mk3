using Core_Mk3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Core_Mk3
{
    public partial class Form2 : Form
    {
        #region _____Переменные_____
        private Arena _arena;
        private TableLayoutPanel _stoneGrid;
        /*
        private TableLayoutPanelCellPosition _previousStonePosition = new TableLayoutPanelCellPosition(-1, -1);
        private const int _gridSize = 8;
        private EStoneType[,] _stoneGridArray = new EStoneType[_gridSize, _gridSize];
        private Random _random = new Random();
        private readonly int[] _offsetX = { -1, 0, 0, 1 };
        private readonly int[] _offsetY = { 0, 1, -1, 0 };
        //Переменные для таймера
        private int _timerSwitch = 0;
        private List<(int, int)>? _timerListOfRemovedStones;
        private EStoneType _timerInitStoneType;
        private int _timerCombinationSize;
        */
        #endregion 

        #region ______Функции первоначальной инициализации поля______
        public Form2(Arena arena)
        {
            InitializeComponent();
            _arena = arena;
            _arena.InitializeGridArray();
            InitializeGrid();
            InitializeButtons();
            _arena = arena;
            UpdateGrid();
            _arena._player.Character.Icon = Resources.FireKnightIcon;
            _arena._enemy.Character.Icon = Resources.FireKnightIcon;
            UpdatePlayerCard(_arena._player);
            UpdateEnemyCard(_arena._enemy);
        }

        public void InitializeGrid()
        {
            _stoneGrid = new TableLayoutPanel();
            _stoneGrid.AutoSize = true;
            _stoneGrid.ColumnCount = _arena.GetGridSize();
            _stoneGrid.RowCount = _arena.GetGridSize();
            _stoneGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            _stoneGrid.Location = new Point(1920 / 2 - 256, 1080 / 2 - 256);
            //При изменении цвета таблицы камни в таблице начинают грузиться с видимой задержкой
            //_stoneGrid.BackColor = Color.Transparent;
            _stoneGrid.Show();
            Controls.Add(_stoneGrid);
            for (int i = 0; i < _stoneGrid.ColumnCount; i++)
            {
                _stoneGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64));
                _stoneGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
                for (int j = 0; j < _stoneGrid.ColumnCount; j++)
                {
                    _stoneGrid.Controls.Add(CreateStone(), i, j);
                }
            }
        }
        
        public void CreatePlayerSpellButton(int i)
        {
            Button button = new Button();
            button.Width = 213;
            button.Height = 27;
            button.Text = "PlayerSpellButton " + (i+1).ToString();
            button.Location = new Point(20, 725 + (button.Height+12) * i);
            Controls.Add(button);
            button.BringToFront();
            button.Show();
        }
        public void CreateEnemySpellButton(int i)
        {
            Button button = new Button();
            button.Text = "EnemySpellButton " + (i+1).ToString();
            button.Width = 213;
            button.Height = 27;
            button.Location = new Point(Width - pictureBox2.Width + 20, 725 + (button.Height+12) * i);
            Controls.Add(button);
            button.BringToFront();
            button.Show();
        }
        public void InitializeButtons()
        {
            for (int i = 0; i < 9; i++)
            {
                CreatePlayerSpellButton(i);
                CreateEnemySpellButton(i);
            }
        }
        
        private PictureBox CreateStone()
        {
            PictureBox Stone = new PictureBox();
            Stone.Dock = DockStyle.Fill;
            Stone.Margin = new Padding(0);
            Stone.BackColor = Color.Transparent;
            Stone.Click += new EventHandler(StoneClick);
            Stone.Dock = DockStyle.Fill;
            return Stone;
        }
        private Image GetPicture(EStoneType stoneType)
        {
            return stoneType switch
            {
                EStoneType.Skull => Resources.SkullIcon,
                EStoneType.Gold => Resources.GoldIcon,
                EStoneType.Experience => Resources.XPIcon,
                EStoneType.FireStone => Resources.FireIcon,
                EStoneType.WaterStone => Resources.WaterIcon,
                EStoneType.AirStone => Resources.AirIcon,
                EStoneType.EarthStone => Resources.EarthIcon,
                _ => null,
            };
        }
        private void DrawStone(int x, int y)
        {
            PictureBox l = _stoneGrid.GetControlFromPosition(x, y) as PictureBox;
            l.Image = GetPicture(_arena.GetGridArray()[x, y]);
        }
        private void UpdateGrid()
        {
            for (int i = 0; i < _arena.GetGridSize(); i++)
            {
                for (int j = 0; j < _arena.GetGridSize(); j++)
                {
                    DrawStone(i, j);
                }
            }
        }

        #endregion

        #region _____Функции пошаговой отрисовки совмещения_____ 
        public void PaintFallingStones(List<(int, int)> RemovedStones)//Закрашивание и открашивание камней, который должны упасть
        {
            for (int i = 0; i < RemovedStones.Count(); i++)
            {
                for (int j = RemovedStones[i].Item2; j >= 0; j--)
                {
                    if (_stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, j).BackColor == Color.Transparent)
                    {
                        _stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, j).BackColor = Color.Blue;
                    }
                    else if (_stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, j).BackColor == Color.Blue)
                    {
                        _stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, j).BackColor = Color.Transparent;
                    }
                }
            }
        }
        public void PaintRemovedStones(List<(int, int)> RemovedStones)//Закрашивание камней, которые должны быть удалены
        {
            for (int i = 0; i < RemovedStones.Count; i++)
            {
                if (_stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, RemovedStones[i].Item2).BackColor == Color.Transparent)
                {
                    _stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, RemovedStones[i].Item2).BackColor = Color.Red;
                }
                else if (_stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, RemovedStones[i].Item2).BackColor == Color.Red)
                {
                    _stoneGrid.GetControlFromPosition(RemovedStones[i].Item1, RemovedStones[i].Item2).BackColor = Color.Transparent;
                }
            }
        }
        public void UnpaintRemovedStones(List<(int, int)> RemovedStones)//Открашивание камней, которые должны быть удалены
        {
            for (int k = 0; k < RemovedStones.Count; k++)
            {

            }
        }
        #endregion

        #region _____Функции совмещения_____
        private void StoneClick(object sender, EventArgs e)
        {
            PictureBox Stone = sender as PictureBox;
            TableLayoutPanelCellPosition CurrentStonePosition = _stoneGrid.GetCellPosition(Stone);
            _arena.StoneClick(CurrentStonePosition.Column, CurrentStonePosition.Row);
            UpdateGrid();
        }
        #endregion

        private void DrawButton_Click(object sender, EventArgs e)
        {
            UpdatePlayerCard(_arena._player);
            UpdateEnemyCard(_arena._enemy);
        }
        public void UpdatePlayerCard(CharacterSlot character)
        {
            _nameLabelPlayer.Text = character.Character.Name;
            _iconPictureBoxPlayer.Image = character.Character.Icon;
            var allMana = new[]
            {
                character.Data[ECharacteristic.Earth][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Fire][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Air][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Water][EDerivative.MaxMana].FinalValue,
            };
            var startMana = new[]
            {
                character.Data[ECharacteristic.Earth][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Fire][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Air][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Water][EDerivative.CurrentMana].FinalValue,
            };
            var maxMana = allMana.Max();
            Size size = new Size(width: _manaBarsPanelPlayer.Width, height: _manaBarsPanelPlayer.Height);
            var manaBarWidth = 25;
            var radius = manaBarWidth / 2;
            Graphics g = _manaBarsPanelPlayer.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.FromArgb(25, 23, 24)), 0, 0, size.Width, size.Height);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var manaColors = new (Color center, Color side)[]
            {
                (Color.LightGreen, Color.Green),
                (Color.Red, Color.Red),
                (Color.Gold, Color.Goldenrod),
                (Color.SkyBlue, Color.DodgerBlue),
            };


            for (int i = 0; i < 4; i++)
            {
                var currentX = 52 * i;
                // Пересчитываем Y-координату так, чтобы верхней точкой была нижняя граница size.Y + size.Height,
                // а высота полосы маны была направлена вверх
                var currentY = size.Height - (int)(size.Height * allMana[i] / maxMana) + radius;
                var currentHeight = (int)(size.Height * allMana[i] / maxMana) - radius;
                var currentWidth = manaBarWidth;

                // Создаем объект LinearGradientBrush для создания градиента
                LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(currentX, currentY, currentWidth, currentHeight),
                    manaColors[i].side,
                    Color.FromArgb(25, 23, 24),
                    LinearGradientMode.Horizontal)
                {
                    // Определяем распределение цвета по градиенту
                    Blend = new Blend
                    {
                        Factors = [0.7f, 1.0f, 0.7f],
                        Positions = [0.0f, 0.5f, 1.0f]
                    }
                };

                g.FillRectangle(brush, currentX, currentY, currentWidth, currentHeight);
                g.FillPie(brush, currentX, currentY - radius + 1, manaBarWidth, manaBarWidth, 180, 180);

                //currentX = 57 * i;
                // Пересчитываем Y-координату так, чтобы верхней точкой была нижняя граница size.Y + size.Height,
                // а высота полосы маны была направлена вверх
                currentY = size.Height - (int)(size.Height * startMana[i] / maxMana) + radius;
                currentHeight = (int)(size.Height * startMana[i] / maxMana) - radius;
                currentWidth = manaBarWidth;

                // Создаем объект LinearGradientBrush для создания градиента
                brush = new LinearGradientBrush(
                    new Rectangle(currentX, currentY, currentWidth, currentHeight),
                    manaColors[i].center,
                    Color.FromArgb(55, 53, 54),
                    LinearGradientMode.Horizontal)
                {
                    // Определяем распределение цвета по градиенту
                    Blend = new Blend
                    {
                        Factors = [0.7f, 0.0f, 0.7f],
                        Positions = [0.0f, 0.5f, 1.0f]
                    }
                };

                g.FillRectangle(brush, currentX, currentY, currentWidth, currentHeight);
                g.FillPie(brush, currentX, currentY - radius + 1, manaBarWidth, manaBarWidth, 180, 180);
            }
            _manaCountEarthLabelPlayer.Text = startMana[0].ToString("F1");
            _manaCountFireLabelPlayer.Text = startMana[1].ToString("F1");
            _manaCountAirLabelPlayer.Text = startMana[2].ToString("F1");
            _manaCountWaterLabelPlayer.Text = startMana[3].ToString("F1");

        }
        public void UpdateEnemyCard(CharacterSlot character)
        {
            _nameLabelEnemy.Text = character.Character.Name;
            _iconPictureBoxEnemy.Image = character.Character.Icon;
            var allMana = new[]
            {
                character.Data[ECharacteristic.Earth][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Fire][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Air][EDerivative.MaxMana].FinalValue,
                character.Data[ECharacteristic.Water][EDerivative.MaxMana].FinalValue,
            };
            var startMana = new[]
            {
                character.Data[ECharacteristic.Earth][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Fire][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Air][EDerivative.CurrentMana].FinalValue,
                character.Data[ECharacteristic.Water][EDerivative.CurrentMana].FinalValue,
            };
            var maxMana = allMana.Max();
            Size size = new Size(width: _manaBarsPanelEnemy.Width, height: _manaBarsPanelEnemy.Height);
            var manaBarWidth = 25;
            var radius = manaBarWidth / 2;
            Graphics g = _manaBarsPanelEnemy.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.FromArgb(25, 23, 24)), 0, 0, size.Width, size.Height);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var manaColors = new (Color center, Color side)[]
            {
                (Color.LightGreen, Color.Green),
                (Color.Red, Color.Red),
                (Color.Gold, Color.Goldenrod),
                (Color.SkyBlue, Color.DodgerBlue),
            };


            for (int i = 0; i < 4; i++)
            {
                var currentX = 52 * i;
                // Пересчитываем Y-координату так, чтобы верхней точкой была нижняя граница size.Y + size.Height,
                // а высота полосы маны была направлена вверх
                var currentY = size.Height - (int)(size.Height * allMana[i] / maxMana) + radius;
                var currentHeight = (int)(size.Height * allMana[i] / maxMana) - radius;
                var currentWidth = manaBarWidth;

                // Создаем объект LinearGradientBrush для создания градиента
                LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(currentX, currentY, currentWidth, currentHeight),
                    manaColors[i].side,
                    Color.FromArgb(25, 23, 24),
                    LinearGradientMode.Horizontal)
                {
                    // Определяем распределение цвета по градиенту
                    Blend = new Blend
                    {
                        Factors = [0.7f, 1.0f, 0.7f],
                        Positions = [0.0f, 0.5f, 1.0f]
                    }
                };

                g.FillRectangle(brush, currentX, currentY, currentWidth, currentHeight);
                g.FillPie(brush, currentX, currentY - radius + 1, manaBarWidth, manaBarWidth, 180, 180);

                //currentX = 57 * i;
                // Пересчитываем Y-координату так, чтобы верхней точкой была нижняя граница size.Y + size.Height,
                // а высота полосы маны была направлена вверх
                currentY = size.Height - (int)(size.Height * startMana[i] / maxMana) + radius;
                currentHeight = (int)(size.Height * startMana[i] / maxMana) - radius;
                currentWidth = manaBarWidth;

                // Создаем объект LinearGradientBrush для создания градиента
                brush = new LinearGradientBrush(
                    new Rectangle(currentX, currentY, currentWidth, currentHeight),
                    manaColors[i].center,
                    Color.FromArgb(55, 53, 54),
                    LinearGradientMode.Horizontal)
                {
                    // Определяем распределение цвета по градиенту
                    Blend = new Blend
                    {
                        Factors = [0.7f, 0.0f, 0.7f],
                        Positions = [0.0f, 0.5f, 1.0f]
                    }
                };

                g.FillRectangle(brush, currentX, currentY, currentWidth, currentHeight);
                g.FillPie(brush, currentX, currentY - radius + 1, manaBarWidth, manaBarWidth, 180, 180);
            }
            _manaCountEarthLabelEnemy.Text = startMana[0].ToString("F1");
            _manaCountFireLabelEnemy.Text = startMana[1].ToString("F1");
            _manaCountAirLabelEnemy.Text = startMana[2].ToString("F1");
            _manaCountWaterLabelEnemy.Text = startMana[3].ToString("F1");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            _arena.InitializeGridArray();
            UpdateGrid();
        }
    }
}
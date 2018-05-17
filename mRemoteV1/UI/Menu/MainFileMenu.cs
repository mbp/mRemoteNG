using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Util;
using mRemoteNG.App;
using mRemoteNG.App.Info;
using mRemoteNG.Connection;
using mRemoteNG.Container;
using mRemoteNG.Security;
using mRemoteNG.Tree;
using mRemoteNG.UI.Forms;
using mRemoteNG.UI.Window;

namespace mRemoteNG.UI.Menu
{
    public class MainFileMenu : ToolStripMenuItem
    {
        private ToolStripMenuItem _mMenFileNew;
        private ToolStripMenuItem _mMenFileLoad;
        private ToolStripMenuItem _mMenFileSave;
        private ToolStripMenuItem _mMenFileSaveAs;
        private ToolStripSeparator _mMenFileSep1;
        private ToolStripMenuItem _mMenFileExit;
        private ToolStripMenuItem _mMenFileDuplicate;
        private ToolStripSeparator _mMenFileSep2;
        private ToolStripMenuItem _mMenFileNewConnection;
        private ToolStripMenuItem _mMenFileNewFolder;
        private ToolStripSeparator _mMenFileSep3;
        private ToolStripSeparator _mMenFileSep4;
        private ToolStripMenuItem _mMenFileDelete;
        private ToolStripMenuItem _mMenFileRename;
        private ToolStripSeparator _mMenFileSep5;
        private ToolStripMenuItem _mMenFileExport;
        private ToolStripMenuItem _mMenFileImportFromFile;
        private ToolStripMenuItem _mMenFileImportFromActiveDirectory;
        private ToolStripMenuItem _mMenFileImportFromPortScan;
        private ToolStripMenuItem _mMenFileImportFromAWS;
        private ToolStripMenuItem _mMenFileImport;
        private ToolStripMenuItem _mMenReconnectAll;

        public ConnectionTreeWindow TreeWindow { get; set; }
        public IConnectionInitiator ConnectionInitiator { get; set; }

        public MainFileMenu()
        {
            Initialize();
        }

        private void Initialize()
        {
            _mMenFileNewConnection = new ToolStripMenuItem();
            _mMenFileNewFolder = new ToolStripMenuItem();
            _mMenFileSep1 = new ToolStripSeparator();
            _mMenFileNew = new ToolStripMenuItem();
            _mMenFileLoad = new ToolStripMenuItem();
            _mMenFileSave = new ToolStripMenuItem();
            _mMenFileSaveAs = new ToolStripMenuItem();
            _mMenFileSep2 = new ToolStripSeparator();
            _mMenFileDelete = new ToolStripMenuItem();
            _mMenFileRename = new ToolStripMenuItem();
            _mMenFileDuplicate = new ToolStripMenuItem();
            _mMenFileSep4 = new ToolStripSeparator();
            _mMenReconnectAll = new ToolStripMenuItem();
            _mMenFileSep3 = new ToolStripSeparator();
            _mMenFileImport = new ToolStripMenuItem();
            _mMenFileImportFromFile = new ToolStripMenuItem();
            _mMenFileImportFromActiveDirectory = new ToolStripMenuItem();
            _mMenFileImportFromPortScan = new ToolStripMenuItem();
            _mMenFileImportFromAWS = new ToolStripMenuItem();
            _mMenFileExport = new ToolStripMenuItem();
            _mMenFileSep5 = new ToolStripSeparator();
            _mMenFileExit = new ToolStripMenuItem();

            // 
            // mMenFile
            // 
            DropDownItems.AddRange(new ToolStripItem[] {
                _mMenFileNewConnection,
                _mMenFileNewFolder,
                _mMenFileSep1,
                _mMenFileNew,
                _mMenFileLoad,
                _mMenFileSave,
                _mMenFileSaveAs,
                _mMenFileSep2,
                _mMenFileDelete,
                _mMenFileRename,
                _mMenFileDuplicate,
                _mMenFileSep4,
                _mMenReconnectAll,
                _mMenFileSep3,
                _mMenFileImport,
                _mMenFileExport,
                _mMenFileSep5,
                _mMenFileExit
            });
            Name = "mMenFile";
            Size = new System.Drawing.Size(37, 20);
            Text = Language.strMenuFile;
            //DropDownOpening += mMenFile_DropDownOpening;
            // 
            // mMenFileNewConnection
            // 
            _mMenFileNewConnection.Image = Resources.Connection_Add;
            _mMenFileNewConnection.Name = "mMenFileNewConnection";
            _mMenFileNewConnection.ShortcutKeys = Keys.Control | Keys.N;
            _mMenFileNewConnection.Size = new System.Drawing.Size(281, 22);
            _mMenFileNewConnection.Text = Language.strNewConnection;
            _mMenFileNewConnection.Click += mMenFileNewConnection_Click;
            // 
            // mMenFileNewFolder
            // 
            _mMenFileNewFolder.Image = Resources.Folder_Add;
            _mMenFileNewFolder.Name = "mMenFileNewFolder";
            _mMenFileNewFolder.ShortcutKeys = (Keys.Control | Keys.Shift)
                                              | Keys.N;
            _mMenFileNewFolder.Size = new System.Drawing.Size(281, 22);
            _mMenFileNewFolder.Text = Language.strNewFolder;
            _mMenFileNewFolder.Click += mMenFileNewFolder_Click;
            // 
            // mMenFileSep1
            // 
            _mMenFileSep1.Name = "mMenFileSep1";
            _mMenFileSep1.Size = new System.Drawing.Size(278, 6);
            // 
            // mMenFileNew
            // 
            _mMenFileNew.Image = Resources.Connections_New;
            _mMenFileNew.Name = "mMenFileNew";
            _mMenFileNew.Size = new System.Drawing.Size(281, 22);
            _mMenFileNew.Text = Language.strMenuNewConnectionFile;
            _mMenFileNew.Click += mMenFileNew_Click;
            // 
            // mMenFileLoad
            // 
            _mMenFileLoad.Image = Resources.Connections_Load;
            _mMenFileLoad.Name = "mMenFileLoad";
            _mMenFileLoad.ShortcutKeys = Keys.Control | Keys.O;
            _mMenFileLoad.Size = new System.Drawing.Size(281, 22);
            _mMenFileLoad.Text = Language.strMenuOpenConnectionFile;
            _mMenFileLoad.Click += mMenFileLoad_Click;
            // 
            // mMenFileSave
            // 
            _mMenFileSave.Image = Resources.Connections_Save;
            _mMenFileSave.Name = "mMenFileSave";
            _mMenFileSave.ShortcutKeys = Keys.Control | Keys.S;
            _mMenFileSave.Size = new System.Drawing.Size(281, 22);
            _mMenFileSave.Text = Language.strMenuSaveConnectionFile;
            _mMenFileSave.Click += mMenFileSave_Click;
            // 
            // mMenFileSaveAs
            // 
            _mMenFileSaveAs.Image = Resources.Connections_SaveAs;
            _mMenFileSaveAs.Name = "mMenFileSaveAs";
            _mMenFileSaveAs.ShortcutKeys = (Keys.Control | Keys.Shift)
                                           | Keys.S;
            _mMenFileSaveAs.Size = new System.Drawing.Size(281, 22);
            _mMenFileSaveAs.Text = Language.strMenuSaveConnectionFileAs;
            _mMenFileSaveAs.Click += mMenFileSaveAs_Click;
            // 
            // mMenFileSep2
            // 
            _mMenFileSep2.Name = "mMenFileSep2";
            _mMenFileSep2.Size = new System.Drawing.Size(278, 6);
            // 
            // mMenFileDelete
            // 
            _mMenFileDelete.Image = Resources.Delete;
            _mMenFileDelete.Name = "mMenFileDelete";
            _mMenFileDelete.Size = new System.Drawing.Size(281, 22);
            _mMenFileDelete.Text = "Delete...";
            _mMenFileDelete.Click += mMenFileDelete_Click;
            // 
            // mMenFileRename
            // 
            _mMenFileRename.Image = Resources.Rename;
            _mMenFileRename.Name = "mMenFileRename";
            _mMenFileRename.Size = new System.Drawing.Size(281, 22);
            _mMenFileRename.Text = "Rename";
            _mMenFileRename.Click += mMenFileRename_Click;
            // 
            // mMenFileDuplicate
            // 
            _mMenFileDuplicate.Image = Resources.page_copy;
            _mMenFileDuplicate.Name = "mMenFileDuplicate";
            _mMenFileDuplicate.Size = new System.Drawing.Size(281, 22);
            _mMenFileDuplicate.Text = "Duplicate";
            _mMenFileDuplicate.Click += mMenFileDuplicate_Click;
            // 
            // mMenFileSep4
            // 
            _mMenFileSep4.Name = "mMenFileSep4";
            _mMenFileSep4.Size = new System.Drawing.Size(278, 6);
            // 
            // mMenReconnectAll
            // 
            _mMenReconnectAll.Image = Resources.Refresh;
            _mMenReconnectAll.Name = "mMenReconnectAll";
            _mMenReconnectAll.Size = new System.Drawing.Size(281, 22);
            _mMenReconnectAll.Text = "Reconnect All Connections";
            _mMenReconnectAll.Click += mMenReconnectAll_Click;
            // 
            // mMenFileSep3
            // 
            _mMenFileSep3.Name = "mMenFileSep3";
            _mMenFileSep3.Size = new System.Drawing.Size(278, 6);
            // 
            // mMenFileImport
            // 
            _mMenFileImport.DropDownItems.AddRange(new ToolStripItem[] {
            _mMenFileImportFromFile,
            _mMenFileImportFromActiveDirectory,
            _mMenFileImportFromPortScan,
            _mMenFileImportFromAWS});
            _mMenFileImport.Name = "mMenFileImport";
            _mMenFileImport.Size = new System.Drawing.Size(281, 22);
            _mMenFileImport.Text = Language.strImportMenuItem;
            // 
            // mMenFileImportFromFile
            // 
            _mMenFileImportFromFile.Name = "mMenFileImportFromFile";
            _mMenFileImportFromFile.Size = new System.Drawing.Size(235, 22);
            _mMenFileImportFromFile.Text = Language.strImportFromFileMenuItem;
            _mMenFileImportFromFile.Click += mMenFileImportFromFile_Click;
            // 
            // mMenFileImportFromActiveDirectory
            // 
            _mMenFileImportFromActiveDirectory.Name = "mMenFileImportFromActiveDirectory";
            _mMenFileImportFromActiveDirectory.Size = new System.Drawing.Size(235, 22);
            _mMenFileImportFromActiveDirectory.Text = Language.strImportAD;
            _mMenFileImportFromActiveDirectory.Click += mMenFileImportFromActiveDirectory_Click;
            // 
            // mMenFileImportFromPortScan
            // 
            _mMenFileImportFromPortScan.Name = "mMenFileImportFromPortScan";
            _mMenFileImportFromPortScan.Size = new System.Drawing.Size(235, 22);
            _mMenFileImportFromPortScan.Text = Language.strImportPortScan;
            _mMenFileImportFromPortScan.Click += mMenFileImportFromPortScan_Click;
            // 
            // mMenFileImportFromAWS
            // 
            _mMenFileImportFromAWS.Name = "mMenFileImportFromAWS";
            _mMenFileImportFromAWS.Size = new System.Drawing.Size(235, 22);
            _mMenFileImportFromAWS.Text = "Import from AWS";
            _mMenFileImportFromAWS.ShortcutKeys = (Keys.Control | Keys.A);
            _mMenFileImportFromAWS.Click += mMenFileImportFromAWS_Click;
            // 
            // mMenFileExport
            // 
            _mMenFileExport.Name = "mMenFileExport";
            _mMenFileExport.Size = new System.Drawing.Size(281, 22);
            _mMenFileExport.Text = Language.strExportToFileMenuItem;
            _mMenFileExport.Click += mMenFileExport_Click;
            // 
            // mMenFileSep5
            // 
            _mMenFileSep5.Name = "mMenFileSep5";
            _mMenFileSep5.Size = new System.Drawing.Size(278, 6);
            // 
            // mMenFileExit
            // 
            _mMenFileExit.Image = Resources.Quit;
            _mMenFileExit.Name = "mMenFileExit";
            _mMenFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            _mMenFileExit.Size = new System.Drawing.Size(281, 22);
            _mMenFileExit.Text = Language.strMenuExit;
            _mMenFileExit.Click += mMenFileExit_Click;
        }

        #region File
        internal void mMenFile_DropDownOpening(object sender, EventArgs e)
        {
            var selectedNodeType = TreeWindow.SelectedNode?.GetTreeNodeType();
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (selectedNodeType)
            {
                case TreeNodeType.Root:
                    _mMenFileNewConnection.Enabled = true;
                    _mMenFileNewFolder.Enabled = true;
                    _mMenFileDelete.Enabled = false;
                    _mMenFileRename.Enabled = true;
                    _mMenFileDuplicate.Enabled = false;
                    _mMenReconnectAll.Enabled = true;
                    _mMenFileDelete.Text = Language.strMenuDelete;
                    _mMenFileRename.Text = Language.strMenuRenameFolder;
                    _mMenFileDuplicate.Text = Language.strMenuDuplicate;
                    _mMenReconnectAll.Text = Language.strMenuReconnectAll;
                    break;
                case TreeNodeType.Container:
                    _mMenFileNewConnection.Enabled = true;
                    _mMenFileNewFolder.Enabled = true;
                    _mMenFileDelete.Enabled = true;
                    _mMenFileRename.Enabled = true;
                    _mMenFileDuplicate.Enabled = true;
                    _mMenReconnectAll.Enabled = true;
                    _mMenFileDelete.Text = Language.strMenuDeleteFolder;
                    _mMenFileRename.Text = Language.strMenuRenameFolder;
                    _mMenFileDuplicate.Text = Language.strMenuDuplicateFolder;
                    _mMenReconnectAll.Text = Language.strMenuReconnectAll;
                    break;
                case TreeNodeType.Connection:
                    _mMenFileNewConnection.Enabled = true;
                    _mMenFileNewFolder.Enabled = true;
                    _mMenFileDelete.Enabled = true;
                    _mMenFileRename.Enabled = true;
                    _mMenFileDuplicate.Enabled = true;
                    _mMenReconnectAll.Enabled = true;
                    _mMenFileDelete.Text = Language.strMenuDeleteConnection;
                    _mMenFileRename.Text = Language.strMenuRenameConnection;
                    _mMenFileDuplicate.Text = Language.strMenuDuplicateConnection;
                    _mMenReconnectAll.Text = Language.strMenuReconnectAll;
                    break;
                case TreeNodeType.PuttyRoot:
                case TreeNodeType.PuttySession:
                    _mMenFileNewConnection.Enabled = false;
                    _mMenFileNewFolder.Enabled = false;
                    _mMenFileDelete.Enabled = false;
                    _mMenFileRename.Enabled = false;
                    _mMenFileDuplicate.Enabled = false;
                    _mMenReconnectAll.Enabled = true;
                    _mMenFileDelete.Text = Language.strMenuDelete;
                    _mMenFileRename.Text = Language.strMenuRename;
                    _mMenFileDuplicate.Text = Language.strMenuDuplicate;
                    _mMenReconnectAll.Text = Language.strMenuReconnectAll;
                    break;
                default:
                    _mMenFileNewConnection.Enabled = true;
                    _mMenFileNewFolder.Enabled = true;
                    _mMenFileDelete.Enabled = false;
                    _mMenFileRename.Enabled = false;
                    _mMenFileDuplicate.Enabled = false;
                    _mMenReconnectAll.Enabled = true;
                    _mMenFileDelete.Text = Language.strMenuDelete;
                    _mMenFileRename.Text = Language.strMenuRename;
                    _mMenFileDuplicate.Text = Language.strMenuDuplicate;
                    _mMenReconnectAll.Text = Language.strMenuReconnectAll;
                    break;
            }
        }

        private void mMenFileNewConnection_Click(object sender, EventArgs e)
        {
            TreeWindow.ConnectionTree.AddConnection();
        }

        private void mMenFileNewFolder_Click(object sender, EventArgs e)
        {
            TreeWindow.ConnectionTree.AddFolder();
        }

        private void mMenFileNew_Click(object sender, EventArgs e)
        {
            var saveFileDialog = ConnectionsSaveAsDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Runtime.ConnectionsService.NewConnectionsFile(saveFileDialog.FileName);
        }

        private void mMenFileLoad_Click(object sender, EventArgs e)
        {
            if (Runtime.ConnectionsService.IsConnectionsFileLoaded)
            {
                var msgBoxResult = MessageBox.Show(Language.strSaveConnectionsFileBeforeOpeningAnother, Language.strSave, MessageBoxButtons.YesNoCancel);
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (msgBoxResult)
                {
                    case DialogResult.Yes:
                        Runtime.ConnectionsService.SaveConnections();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            Runtime.LoadConnections(true);
        }

        private void mMenFileSave_Click(object sender, EventArgs e)
        {
            Runtime.ConnectionsService.SaveConnectionsAsync();
        }

        private void mMenFileSaveAs_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.InitialDirectory = ConnectionsFileInfo.DefaultConnectionsPath;
                saveFileDialog.FileName = ConnectionsFileInfo.DefaultConnectionsFile;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.Filter = $@"{Language.strFiltermRemoteXML}|*.xml|{Language.strFilterAll}|*.*";

                if (saveFileDialog.ShowDialog(FrmMain.Default) != DialogResult.OK) return;
                var newFileName = saveFileDialog.FileName;

                Runtime.ConnectionsService.SaveConnections(Runtime.ConnectionsService.ConnectionTreeModel, false, new SaveFilter(), newFileName);

                if (newFileName == Runtime.ConnectionsService.GetDefaultStartupConnectionFileName())
                {
                    Settings.Default.LoadConsFromCustomLocation = false;
                }
                else
                {
                    Settings.Default.LoadConsFromCustomLocation = true;
                    Settings.Default.CustomConsPath = newFileName;
                }
            }
        }

        private void mMenFileDelete_Click(object sender, EventArgs e)
        {
            TreeWindow.ConnectionTree.DeleteSelectedNode();
        }

        private void mMenFileRename_Click(object sender, EventArgs e)
        {
            TreeWindow.ConnectionTree.RenameSelectedNode();
        }

        private void mMenFileDuplicate_Click(object sender, EventArgs e)
        {
            TreeWindow.ConnectionTree.DuplicateSelectedNode();
        }

        private void mMenReconnectAll_Click(object sender, EventArgs e)
        {
            if (Runtime.WindowList == null || Runtime.WindowList.Count == 0) return;
            foreach (BaseWindow window in Runtime.WindowList)
            {
                var connectionWindow = window as ConnectionWindow;
                if (connectionWindow == null)
                    return;

                var icList = new List<InterfaceControl>();
                foreach (Crownwood.Magic.Controls.TabPage tab in connectionWindow.TabController.TabPages)
                {
                    var tag = tab.Tag as InterfaceControl;
                    if (tag != null)
                    {
                        icList.Add(tag);
                    }
                }

                foreach (var i in icList)
                {
                    i.Protocol.Close();
                    ConnectionInitiator.OpenConnection(i.Info, ConnectionInfo.Force.DoNotJump);
                }

                // throw it on the garbage collector
                // ReSharper disable once RedundantAssignment
                icList = null;
            }
        }

        private void mMenFileImportFromFile_Click(object sender, EventArgs e)
        {
            var selectedNode = TreeWindow.SelectedNode;
            ContainerInfo importDestination;
            if (selectedNode == null)
                importDestination = Runtime.ConnectionsService.ConnectionTreeModel.RootNodes.First();
            else
                importDestination = selectedNode as ContainerInfo ?? selectedNode.Parent;
            Import.ImportFromFile(importDestination);
        }

        private void mMenFileImportFromActiveDirectory_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.ActiveDirectoryImport);
        }

        private void mMenFileImportFromPortScan_Click(object sender, EventArgs e)
        {
            Windows.Show(WindowType.PortScan);
        }

        private async void mMenFileImportFromAWS_Click(object sender, EventArgs e)
        {
            var rootNode = Runtime.ConnectionsService.ConnectionTreeModel.RootNodes.First();
            var awsNodes = rootNode.Children.Where(x => x.Description == "awsGeneratedNode").ToArray();

            var addedRegionContainers = new List<string>();
            foreach (var profile in ProfileManager.ListProfiles())
            {
                var credentials = ProfileManager.GetAWSCredentials(profile.Name);

                foreach (var endpointName in Settings.Default.AwsRegions.Split(','))
                {
                    var endpoint = RegionEndpoint.GetBySystemName(endpointName);
                    string name = $"{profile.Name}: { endpoint.DisplayName }";
                    addedRegionContainers.Add(name);
                    var regionContainer = awsNodes.OfType<ContainerInfo>().FirstOrDefault(x => x.Name == name) ?? new ContainerInfo
                    {
                        Name = name,
                        Description = "awsGeneratedNode",
                    };
                    await GetConnectionInfosForProfileAndRegion(profile, credentials, endpoint, regionContainer);
                    if (!awsNodes.OfType<ContainerInfo>().Any(x => x.Name == name))
                    {
                        rootNode.AddChild(regionContainer);
                    }
                }
            }
            rootNode.RemoveChildRange(awsNodes.Where(x => !addedRegionContainers.Contains(x.Name)).ToArray());
            Runtime.ConnectionsService.SaveConnectionsAsync();
        }

        private async Task GetConnectionInfosForProfileAndRegion(ProfileSettingsBase profile, AWSCredentials credentials, RegionEndpoint endpoint, ContainerInfo regionContainer)
        {
            try
            {
                await GetInstances(credentials, endpoint, regionContainer);
            }
            catch (AmazonEC2Exception e)
            {
                // If account does not have permissions, ignore it.
                if (e.StatusCode != HttpStatusCode.Unauthorized && e.StatusCode != HttpStatusCode.Forbidden)
                {
                    throw;
                }
                regionContainer.Name = "no permissions: " + regionContainer.Name;
            }
        }

        private async Task GetInstances(AWSCredentials credentials, RegionEndpoint endpoint, ContainerInfo regionContainer)
        {
            using (var ec2Client = new AmazonEC2Client(credentials, endpoint))
            {
                var describeInstancesResponse = await ec2Client.DescribeInstancesAsync();
                var instances = describeInstancesResponse.Reservations.SelectMany(x => x.Instances)
                    .Where(x => !string.IsNullOrEmpty(x.PublicDnsName) || !string.IsNullOrEmpty(x.PublicIpAddress) || !string.IsNullOrEmpty(x.PrivateIpAddress))
                    .Select(x => new
                    {
                        Instance = x,
                        Environment = x.Tags.FirstOrDefault(tag => tag.Key == "Environment")?.Value,
                        Function = x.Tags.FirstOrDefault(y => y.Key == "Function")?.Value ?? x.Tags.FirstOrDefault(y => y.Key == "Name")?.Value,
                        InstanceGroupName = GetInstanceGroupName(x)
                    });

                var addedEnvironmentNodes = new List<string>();
                foreach (var instanceGroupByEnvironment in instances.GroupBy(x => x.Environment).OrderBy(x => x.Key))
                {
                    string environmentContainerNameName = string.IsNullOrEmpty(instanceGroupByEnvironment.Key) ? "(no environment)" : instanceGroupByEnvironment.Key;
                    addedEnvironmentNodes.Add(environmentContainerNameName);
                    var environmentContainer = regionContainer.Children.OfType<ContainerInfo>().FirstOrDefault(x => x.Name == environmentContainerNameName) ?? new ContainerInfo { Name = environmentContainerNameName };

                    if (!regionContainer.Children.OfType<ContainerInfo>().Any(x => x.Name == environmentContainerNameName))
                    {
                        regionContainer.AddChild(environmentContainer);
                    }

                    var addedFunctionNodes = new List<string>();
                    foreach (var instanceGroupByFunction in instanceGroupByEnvironment.GroupBy(x => x.InstanceGroupName).OrderBy(x => x.Key))
                    {
                        string functionContainerName = string.IsNullOrEmpty(instanceGroupByFunction.Key) ? "(no function)" : instanceGroupByFunction.Key;
                        addedFunctionNodes.Add(functionContainerName);
                        var functionContainer = environmentContainer.Children.OfType<ContainerInfo>().FirstOrDefault(x => x.Name == functionContainerName) ?? new ContainerInfo { Name = functionContainerName };

                        if (!environmentContainer.Children.OfType<ContainerInfo>().Any(x => x.Name == functionContainerName))
                        {
                            environmentContainer.AddChild(functionContainer);
                        }

                        var addedInstanceNodes = new List<string>();
                        foreach (var instance in instanceGroupByFunction.OrderBy(x => x.Instance.InstanceId))
                        {
                            var notRunningState = instance.Instance.State.Name != InstanceStateName.Running ? $"[{instance.Instance.State.Name}] ".ToUpper() : "";
                            string connectionInfoName = $"{instance.Function} {notRunningState}{instance.Instance.InstanceId}";
                            addedInstanceNodes.Add(connectionInfoName);
                            if (functionContainer.Children.Any(x => x.Name == connectionInfoName))
                            {
                                continue;
                            }
                            var connectionInfo = new ConnectionInfo();
                            connectionInfo.Hostname = !string.IsNullOrEmpty(instance.Instance.PublicIpAddress) ? instance.Instance.PublicIpAddress : !string.IsNullOrEmpty(instance.Instance.PublicDnsName) ? instance.Instance.PublicDnsName : instance.Instance.PrivateIpAddress;
                            connectionInfo.Name = connectionInfoName;
                            connectionInfo.Description = $"{instance.Instance.State.Name}";
                            connectionInfo.Protocol = instance.Instance.Platform == PlatformValues.Windows ? Connection.Protocol.ProtocolType.RDP : Connection.Protocol.ProtocolType.SSH2;
                            connectionInfo.Port = instance.Instance.Platform == PlatformValues.Windows ? 3389 : 22;
                            connectionInfo.Icon = instance.Instance.Platform == PlatformValues.Windows ? "Windows" : "Linux";
                            functionContainer.AddChild(connectionInfo);
                        }
                        functionContainer.RemoveChildRange(functionContainer.Children.Where(x => !addedInstanceNodes.Contains(x.Name)).ToArray());
                    }

                    environmentContainer.RemoveChildRange(environmentContainer.Children.Where(x => !addedFunctionNodes.Contains(x.Name)).ToArray());
                }

                regionContainer.RemoveChildRange(regionContainer.Children.Where(x => !addedEnvironmentNodes.Contains(x.Name)).ToArray());
            }
        }

        private string GetInstanceGroupName(Instance instance)
        {
            var stackName = instance.Tags.FirstOrDefault(x => x.Key == "aws:cloudformation:stack-name")?.Value;
            var function = instance.Tags.FirstOrDefault(x => x.Key == "Function")?.Value ?? instance.Tags.FirstOrDefault(x => x.Key == "Name")?.Value;
            if (stackName == null && function == null)
            {
                return "(no category)";
            }
            return function + (stackName != null ? " (" + stackName + ")" : "");
        }

        private void mMenFileExport_Click(object sender, EventArgs e)
        {
            Export.ExportToFile(Windows.TreeForm.SelectedNode, Runtime.ConnectionsService.ConnectionTreeModel);
        }

        private void mMenFileExit_Click(object sender, EventArgs e)
        {
            Shutdown.Quit();
        }

        public static SaveFileDialog ConnectionsSaveAsDialog()
        {
            return new SaveFileDialog
            {
                CheckPathExists = true,
                InitialDirectory = ConnectionsFileInfo.DefaultConnectionsPath,
                FileName = ConnectionsFileInfo.DefaultConnectionsFile,
                OverwritePrompt = true,
                Filter = Language.strFiltermRemoteXML + @"|*.xml|" + Language.strFilterAll + @"|*.*"
            };
        }
        #endregion
    }
}
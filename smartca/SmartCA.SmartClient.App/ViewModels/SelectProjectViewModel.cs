using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Data;
using SmartCA.Infrastructure.UI;
using SmartCA.SmartClient.App.Views;
using SmartCA.Domain.Projects;

namespace SmartCA.SmartClient.App.ViewModels
{
    public class SelectProjectViewModel
    {
        private CollectionView projectsView;
        private DelegateCommand selectCommand;
        private DelegateCommand cancelCommand;
        private IView view;

        public SelectProjectViewModel():this(null)
        {
            
        }

        public SelectProjectViewModel(IView view)
        {
            this.view = view;
            this.projectsView = new CollectionView(ProjectService.GetAllProjects());
            this.selectCommand = new DelegateCommand(this.SelectCommandHandler);
            this.cancelCommand = new DelegateCommand(this.CancelCommandHandler);

        }

        public CollectionView Projects
        {
            get { return this.projectsView; }
        }

        public DelegateCommand SelectCommand
        {
            get { return this.selectCommand; }
        }

        public DelegateCommand CancelCommand
        {
            get { return this.cancelCommand; }
        }

        private void SelectCommandHandler(object sender, EventArgs e)
        {
            Project project = this.projectsView.CurrentItem as Project;
            UserSession.CurrentProject = project;
            this.view.Close();
        }

        private void CancelCommandHandler(object sender, EventArgs e)
        {
            this.view.Close();
        }
    }
}

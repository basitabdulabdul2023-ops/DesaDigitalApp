using CommunityToolkit.Mvvm.Input;
using DesaDigitalApp.Models;

namespace DesaDigitalApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
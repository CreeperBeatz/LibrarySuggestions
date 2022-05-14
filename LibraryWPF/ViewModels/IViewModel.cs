namespace LibraryWPF.ViewModels
{
    public interface IViewModel
    {
        IViewModel CurrentViewModel { get; set; }
        IViewModel CurrentViewModelParent { get; set; }
    }
}
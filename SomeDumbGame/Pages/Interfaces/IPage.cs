namespace SomeDumbGame.Pages.Interfaces
{
    public interface IPage : IPageAsync
    {
        IPage Render();

        ValueTask<IPage> IPageAsync.RenderAsync(CancellationToken cancellationToken) => ValueTask.FromResult(Render());
    }

    public interface IPageAsync
    {
        ValueTask<IPage> RenderAsync(CancellationToken cancellationToken);
    }
}

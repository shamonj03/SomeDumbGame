using SomeDumbGame.Pages.Interfaces;
using SomeDumbGame.Pages.Title;

var source = new CancellationTokenSource();

IPageAsync page = new TitlePage();

while (page != null)
{
    page = await page.RenderAsync(source.Token);
}

using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MarkdownEditor.Pages
{
    public class IndexBase : ComponentBase
    {
        protected string MarkdownContent = string.Empty;

        protected string HtmlPreview = string.Empty;

        protected void UpdateMarkdown()
        {

        }

        //[Inject] private HttpClient Http { get; set; }
        //protected string FileUrl { get; set; }
        //protected string ContentValue { get; set; }

        //protected void TextChanged(UIChangeEventArgs e)
        //{
        //    ContentValue = e.Value.ToString();
        //}

        //protected async override Task OnInitAsync()
        //{
        //    ContentValue = await GetContentFromUrl("/sample-data/example.md");
        //}

        //protected async void OnImportClicked()
        //{
        //    string path = String.IsNullOrWhiteSpace(FileUrl) ? "/sample-data/example.md" : FileUrl;
        //    ContentValue = await GetContentFromUrl(path);
        //    StateHasChanged();
        //}

        //private async Task<string> GetContentFromUrl(string path)
        //{
        //    HttpResponseMessage httpResponse = await Http.GetAsync(path);
        //    return httpResponse.IsSuccessStatusCode ?
        //    await httpResponse.Content.ReadAsStringAsync() : httpResponse.ReasonPhrase;
        //}


        //public string MarkdownContent { get; set; }

        public string Title => "Render Markdown";

        protected override void OnInit()
        {
            MarkdownContent = GetInitialMarkdown();
        }

        private string GetInitialMarkdown()
        {

            return string.Empty;
        }
    }
}
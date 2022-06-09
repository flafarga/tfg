using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using dashboard.Client.Infrastructure.Managers.Dashboard;
using dashboard.Shared.Constants.Application;

namespace dashboard.Client.Pages.Content
{
    public partial class Dashboard
    {
        [Inject] private IDashboardManager DashboardManager { get; set; }

        [CascadingParameter] private HubConnection HubConnection { get; set; }
        [Parameter] public int ProductCount { get; set; }
        [Parameter] public int BrandCount { get; set; }
        [Parameter] public int DocumentCount { get; set; }
        [Parameter] public int DocumentTypeCount { get; set; }
        [Parameter] public int DocumentExtendedAttributeCount { get; set; }
        [Parameter] public int UserCount { get; set; }
        [Parameter] public int RoleCount { get; set; }

        private readonly string[] _dataEnterBarChartXAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private readonly List<ChartSeries> _dataEnterBarChartSeries = new();
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            _loaded = true;
            HubConnection = new HubConnectionBuilder()
            .WithUrl(_navigationManager.ToAbsoluteUri(ApplicationConstants.SignalR.HubUrl)).Build();
            HubConnection.On(ApplicationConstants.SignalR.ReceiveUpdateDashboard, async () =>
            {
                await LoadDataAsync();
                StateHasChanged();
            });
            await HubConnection.StartAsync();
        }

        private async Task LoadDataAsync()
        {
            var response = await DashboardManager.GetDataAsync();
            if (response.Succeeded)
            {
                ProductCount = response.Data.ProductCount;
                BrandCount = response.Data.BrandCount;
                DocumentCount = response.Data.DocumentCount;
                DocumentTypeCount = response.Data.DocumentTypeCount;
                DocumentExtendedAttributeCount = response.Data.DocumentExtendedAttributeCount;
                UserCount = response.Data.UserCount;
                RoleCount = response.Data.RoleCount;
                foreach (var item in response.Data.DataEnterBarChart)
                {
                    _dataEnterBarChartSeries
                        .RemoveAll(x => x.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
                    _dataEnterBarChartSeries.Add(new ChartSeries { Name = item.Name, Data = item.Data });
                }
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private int Index = -1;
        int dataSize = 4;
        public double[] data = { 50, 25, 20, 5 };
        public string[] labels = { "Label_1", "Label_2", "Label_3", "Label_4", "Label_5", "Label_6", "Label_7", "Label_8", "Label_9", "Label_10" };
        public List<ChartSeries> Series = new List<ChartSeries>();
        public ChartOptions Options = new ChartOptions();
        public string[] XAxisLabels = { "2022-02-10", "2022-02-11", "2022-02-12", "2022-02-13", "2022-02-14", "2022-02-15", "2022-02-16" };

        Random random = new Random();

        void RandomizeData()
        {
            var new_data = new double[dataSize];
            for (int i = 0; i < new_data.Length; i++)
            {
                new_data[i] = random.NextDouble() * 100;
            }
            data = new_data;
            StateHasChanged();
        }

        void AddLabelFromCSV()
        {
            if (dataSize < 10)
            {
                dataSize++;
                RandomizeData();
            }
        }
        void RemoveLabel()
        {
            if (dataSize > 0)
            {
                dataSize--;
                RandomizeData();
            }
        }

        protected override void OnInitialized()
        {
            double[] Data1 = { 5, 8, 7, 4, 4, 2, 4 };
            double[] Data2 = { 8, 0, 9, 2, 1, 4, 0 };
            double[] Data3 = { 9, 1, 9, 2, 2, 2, 1 };
            double[] Data4 = { 5, 6, 5, 4, 2, 4, 0 };


            Series.Add(new ChartSeries() { Name = "ph-Reactor-1", Data = Data1 });
            Series.Add(new ChartSeries() { Name = "ph-Reactor-2", Data = Data2 });
            Series.Add(new ChartSeries() { Name = "ph-Reactor-3", Data = Data3 });
            Series.Add(new ChartSeries() { Name = "ph-Reactor-4", Data = Data4 });
        }
    }
}
using SwiftSendLibrary;

namespace SwiftSendUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = string.Empty;

        if (api.IsValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApiAsync(apiText.Text);
            callData.SelectedTab = resultsTab;
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
        {

        }
    }

    private void apiLabel_Click(object sender, EventArgs e)
    {

    }

    private void httpVerbSelection_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void resultsText_TextChanged(object sender, EventArgs e)
    {

    }

    private void resultsText_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void bodyText_TextChanged(object sender, EventArgs e)
    {

    }
}

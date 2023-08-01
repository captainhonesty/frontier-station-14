using Content.Client.UserInterface.Controls;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._NF.M_Emp.UI;

[GenerateTypedNameReferences]
public sealed partial class M_EmpMenu : FancyWindow
{
    public Action? RequestRequested;
    public Action? ActivateRequested;

    public M_EmpMenu()
    {
        RobustXamlLoader.Load(this);
        RequestButton.OnPressed += OnRequestPressed;
        ActivateButton.OnPressed += OnActivatePressed;
        Title = Loc.GetString("m_emp-console-menu-title");
    }

    public void SetAppraisal(int amount)
    {
       // AppraisalLabel.Text = Loc.GetString("cargo-console-menu-points-amount", ("amount", amount.ToString()));
    }

    public void SetCount(int count)
    {
      //  CountLabel.Text = count.ToString();
    }
    public void SetEnabled(bool enabled)
    {
        RequestButton.Disabled = !enabled;
        ActivateButton.Disabled = !enabled;
    }
    private void OnRequestPressed(BaseButton.ButtonEventArgs obj)
    {
        RequestRequested?.Invoke();
    }

    private void OnActivatePressed(BaseButton.ButtonEventArgs obj)
    {
        ActivateRequested?.Invoke();
    }
}

//Code for MainScreen
using Gum;
using Gum.Converters;
using Gum.DataTypes;
using Gum.GueDeriving;
using Gum.Managers;
using Gum.Wireframe;
using GumRuntime;
using RenderingLibrary.Graphics;
using System.Linq;
using Uncle_V.Components;
using Uncle_V.Components.Controls;
namespace Uncle_V.Screens;
partial class MainScreen : global::Gum.Forms.Controls.FrameworkElement
{
    #if UNITY_5_3_OR_NEWER
    [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
    #else
    [System.Runtime.CompilerServices.ModuleInitializer]
    #endif
    public static void RegisterRuntimeType()
    {
        var template = new global::Gum.Forms.VisualTemplate((vm, createForms) =>
        {
            var visual = new global::Gum.GueDeriving.ContainerRuntime();
            var element = ObjectFinder.Self.GetElementSave("MainScreen") ?? throw new System.InvalidOperationException("Could not find an element named MainScreen - did you forget to load a Gum project?");
            element.SetGraphicalUiElement(visual, RenderingLibrary.SystemManagers.Default);
            if(createForms) visual.FormsControlAsObject = new MainScreen(visual);
            visual.Width = 0;
            visual.WidthUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToParent;
            visual.Height = 0;
            visual.HeightUnits = global::Gum.DataTypes.DimensionUnitType.RelativeToParent;
            return visual;
        });
        global::Gum.Forms.Controls.FrameworkElement.DefaultFormsTemplates[typeof(MainScreen)] = template;
        ElementSaveExtensions.RegisterGueInstantiation("MainScreen", () => 
        {
            var gue = template.CreateContent(null, true) as InteractiveGue;
            return gue;
        });
    }
    public Title Title_card { get; protected set; }
    public RectangleRuntime Tips_background { get; protected set; }
    public TextRuntime Tips_text { get; protected set; }
    public ContainerRuntime Start_container { get; protected set; }
    public RectangleRuntime Start_Background { get; protected set; }
    public ButtonStandard Start_button { get; protected set; }
    public TextRuntime Start_text { get; protected set; }
    public ContainerRuntime ContainerInstance1 { get; protected set; }
    public TextRuntime Difficulty { get; protected set; }
    public ComboBox Difficulty_drop { get; protected set; }
    public ListBox ListBoxInstance { get; protected set; }
    public ListBoxItem Easy { get; protected set; }
    public ListBoxItem Normal { get; protected set; }
    public ListBoxItem Hard { get; protected set; }

    public MainScreen(InteractiveGue visual) : base(visual)
    {
    }
    public MainScreen()
    {



    }
    protected override void ReactToVisualChanged()
    {
        base.ReactToVisualChanged();
        Title_card = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<Title>(this.Visual,"Title card");
        Tips_background = this.Visual?.GetGraphicalUiElementByName("Tips background") as global::Gum.GueDeriving.RectangleRuntime;
        Tips_text = this.Visual?.GetGraphicalUiElementByName("Tips text") as global::Gum.GueDeriving.TextRuntime;
        Start_container = this.Visual?.GetGraphicalUiElementByName("Start container") as global::Gum.GueDeriving.ContainerRuntime;
        Start_Background = this.Visual?.GetGraphicalUiElementByName("Start Background") as global::Gum.GueDeriving.RectangleRuntime;
        Start_button = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ButtonStandard>(this.Visual,"Start button");
        Start_text = this.Visual?.GetGraphicalUiElementByName("Start text") as global::Gum.GueDeriving.TextRuntime;
        ContainerInstance1 = this.Visual?.GetGraphicalUiElementByName("ContainerInstance1") as global::Gum.GueDeriving.ContainerRuntime;
        Difficulty = this.Visual?.GetGraphicalUiElementByName("Difficulty") as global::Gum.GueDeriving.TextRuntime;
        Difficulty_drop = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ComboBox>(this.Visual,"Difficulty drop");
        ListBoxInstance = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ListBox>(this.Visual,"ListBoxInstance");
        Easy = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ListBoxItem>(this.Visual,"Easy");
        Normal = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ListBoxItem>(this.Visual,"Normal");
        Hard = global::Gum.Forms.GraphicalUiElementFormsExtensions.FindFormsControl<ListBoxItem>(this.Visual,"Hard");
        CustomInitialize();
    }
    //Not assigning variables because Object Instantiation Type is set to By Name rather than Fully In Code
    partial void CustomInitialize();
}

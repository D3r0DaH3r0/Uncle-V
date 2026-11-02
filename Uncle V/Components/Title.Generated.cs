//Code for Title (Container)
using Gum;
using Gum.Converters;
using Gum.DataTypes;
using Gum.GueDeriving;
using Gum.Managers;
using Gum.Wireframe;
using GumRuntime;
using RenderingLibrary.Graphics;
using System.Linq;
namespace Uncle_V.Components;
partial class Title : global::Gum.Forms.Controls.FrameworkElement
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
            var element = ObjectFinder.Self.GetElementSave("Title") ?? throw new System.InvalidOperationException("Could not find an element named Title - did you forget to load a Gum project?");
            element.SetGraphicalUiElement(visual, RenderingLibrary.SystemManagers.Default);
            if(createForms) visual.FormsControlAsObject = new Title(visual);
            return visual;
        });
        global::Gum.Forms.Controls.FrameworkElement.DefaultFormsTemplates[typeof(Title)] = template;
        ElementSaveExtensions.RegisterGueInstantiation("Title", () => 
        {
            var gue = template.CreateContent(null, true) as InteractiveGue;
            return gue;
        });
    }
    public RectangleRuntime RectangleInstance { get; protected set; }
    public TextRuntime TextInstance { get; protected set; }

    public Title(InteractiveGue visual) : base(visual)
    {
    }
    public Title()
    {



    }
    protected override void ReactToVisualChanged()
    {
        base.ReactToVisualChanged();
        RectangleInstance = this.Visual?.GetGraphicalUiElementByName("RectangleInstance") as global::Gum.GueDeriving.RectangleRuntime;
        TextInstance = this.Visual?.GetGraphicalUiElementByName("TextInstance") as global::Gum.GueDeriving.TextRuntime;
        CustomInitialize();
    }
    //Not assigning variables because Object Instantiation Type is set to By Name rather than Fully In Code
    partial void CustomInitialize();
}

#pragma checksum "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea4f359dad76d68263896f3039716d0b92a927e"
// <auto-generated/>
#pragma warning disable 1591
namespace Handin1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Handin1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\_Imports.razor"
using Handin1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
using Handin1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
           [Authorize(Policy = "MustBeLoggedIn")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Adult</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                            AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "from-group");
                __builder2.AddMarkupContent(11, "\r\n        First name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(12);
                __builder2.AddAttribute(13, "rows", "2");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                             newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "from-group");
                __builder2.AddMarkupContent(20, "\r\n        Last name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(21);
                __builder2.AddAttribute(22, "rows", "2");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                             newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n        Age:<br>\r\n        ");
                __Blazor.Handin1.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 30, 31, 
#nullable restore
#line 23 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                  newAdult.Age

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Age = __value, newAdult.Age)), 33, () => newAdult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "from-group");
                __builder2.AddMarkupContent(37, "\r\n        Sex:<br>\r\n        ");
                __Blazor.Handin1.Pages.AddAdult.TypeInference.CreateInputRadioGroup_1(__builder2, 38, 39, 
#nullable restore
#line 27 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                      newAdult.Sex

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Sex = __value, newAdult.Sex)), 41, () => newAdult.Sex, 42, (__builder3) => {
#nullable restore
#line 28 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
             foreach (var opt in radioOpt)
            {

#line default
#line hidden
#nullable disable
                    __Blazor.Handin1.Pages.AddAdult.TypeInference.CreateInputRadio_2(__builder3, 43, 44, 
#nullable restore
#line 30 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                   opt

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(45, 
#nullable restore
#line 30 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
                                          opt

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(46, "<br>");
#nullable restore
#line 31 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.AddMarkupContent(48, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\AddAdult.razor"
       
    private Adult newAdult = new Adult();
    List<string> radioOpt = new List<string> {" M", " F", " O"};

    private void AddNewAdult()
    {
        Data.AddAdult(newAdult);
        Nav.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsData Data { get; set; }
    }
}
namespace __Blazor.Handin1.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputRadioGroup_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

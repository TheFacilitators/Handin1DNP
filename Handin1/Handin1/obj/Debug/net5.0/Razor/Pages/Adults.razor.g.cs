#pragma checksum "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf0f31478dbb2cbf39d5205390ecd44eb5113647"
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
#line 3 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Person ID</th>\r\n            <th>First name</th>\r\n            <th>Surname</th>\r\n            <th>Age</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 21 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
           foreach (var item in adults) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 23 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                        ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                             item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                             item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                             item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                                                () => EditAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                                                () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Bruger\RiderProjects\DNP1\Handin1\Handin1\Handin1\Pages\Adults.razor"
       
    private IList<Adult> adults;
    
    protected override Task OnInitializedAsync()
    {
        adults = Data.GetAllAdults();
        return base.OnInitializedAsync();
    }

    private void EditAdult(int id)
    {
        Nav.NavigateTo($"EditAdult/{id}");
    }

    private void RemoveAdult(int id)
    {
        Data.RemoveAdult(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsData Data { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92427a3e309f3b3ff448be6f65118c452ef258b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Detalles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Detalles/ListadoDetalles")]
    public partial class ListadoDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado de Detalles</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success mb-2 pt-2");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                    ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus mr-1\"></span>Agregar Detalle");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<p>Panel de control de Detalles</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
 if (detalles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<thead>
            <tr>
                <th>Id</th>
                <th>Fecha</th>
                <th>Tiempo</th>
                <th>Recurso</th>
                <th>Tarea</th>
                <th>Acciones</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 31 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
             foreach (var detail in detalles)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Tiempo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Recurso.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                     detail.Tarea.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-warning");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                              ()=>Editar(detail.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-danger");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
                                                             ()=>Borrar(detail.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 44 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 47 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201110\BlazorApp1\Pages\Detalles\ListadoDetalles.razor"
       
    private List<BlazorApp1.Data.Detalle> detalles;

    protected override async Task OnInitializedAsync()
    {
        detalles = await DetalleService.ListDetail();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("Detalles/EditarDetalles/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar la Detalle?");
        if (confirmed)
        {
            await DetalleService.DeleteDetail(id);
            detalles = await DetalleService.ListDetail();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService DetalleService { get; set; }
    }
}
#pragma warning restore 1591

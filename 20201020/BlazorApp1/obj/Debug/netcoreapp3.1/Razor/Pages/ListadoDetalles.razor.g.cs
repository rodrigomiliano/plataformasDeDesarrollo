#pragma checksum "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e2374211916b60d0f31b97d4ffc7e4b9808864c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoDetalles")]
    public partial class ListadoDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado Detalles</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Visualizador de los DEtalles</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
 if (detalles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Fecha</th>\r\n                <th>Tiempo</th>\r\n                <th>RecursoId</th>\r\n                <th>TareaId</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 27 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
             foreach (var detail in detalles)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
                         detail.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
                         detail.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
                         detail.Tiempo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
                         detail.RecursoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
                         detail.TareaId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 36 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 39 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201020\BlazorApp1\Pages\ListadoDetalles.razor"
       
    private List<Detalle> detalles;

    protected override async Task OnInitializedAsync()
    {
        detalles = DetalleService.ListarDetalle();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService DetalleService { get; set; }
    }
}
#pragma warning restore 1591

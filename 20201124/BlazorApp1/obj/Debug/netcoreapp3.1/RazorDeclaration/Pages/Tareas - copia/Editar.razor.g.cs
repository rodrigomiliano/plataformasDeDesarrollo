#pragma checksum "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\Pages\Tareas - copia\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f3ca691f7306ec0647d91629955395223dc0ca"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Tareas___copia
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\Pages\Tareas - copia\Editar.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tareas/editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201027\BlazorApp1\Pages\Tareas - copia\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Tarea Modelo { get; set; } = new Tarea();

    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Modelo = await service.Get(Id);
        }
        else
        {
            Modelo = new Tarea();
        }
    }


    private async void Guardar()
    {
        await service.Save(Modelo);
        navigation.NavigateTo("tareas/listado");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaService service { get; set; }
    }
}
#pragma warning restore 1591

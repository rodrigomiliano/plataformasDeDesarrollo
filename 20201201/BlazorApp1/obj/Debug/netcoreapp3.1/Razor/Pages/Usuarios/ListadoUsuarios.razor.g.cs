#pragma checksum "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11f01f4aece01156b212d1b8b995f69093ddb74"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuarios/ListadoUsuarios")]
    public partial class ListadoUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado de Usuarios</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success mb-2 pt-2");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                                                    ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<span class=\"oi oi-plus mr-1\"></span>Agregar Usuario");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<p>Panel de control de Usuarios</p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
 if (usuarios == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 17 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
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
            __builder.AddMarkupContent(13, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Nombre</th>\r\n                <th>Clave</th>\r\n                <th>Acciones</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 30 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
             foreach (var user in usuarios)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                         user.UsuarioPK

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                         user.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 35 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                         user.Clave

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-warning");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                                                                  ()=>Editar(user.UsuarioPK)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " \r\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
                                                                 ()=>Borrar(user.UsuarioPK)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 41 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 44 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201201\BlazorApp1\Pages\Usuarios\ListadoUsuarios.razor"
       
    private List<BlazorApp1.Data.Usuario> usuarios;

    protected override async Task OnInitializedAsync()
    {
        //usuarios = await service.ListUser();
        usuarios = await service.GetAll();
        //var tipo = await service.GuardaTarea(new Tarea { Titulo = "blazor"}); NO VA
        //var tipos = await service.GetTareas(); NO VA
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("usuarios/EditarUsuarios/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el usuario?");
        if (confirmed)
        {
            await service.DeleteUser(id);
            usuarios = await service.GetAll();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioService service { get; set; }
    }
}
#pragma warning restore 1591

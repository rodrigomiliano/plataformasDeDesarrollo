#pragma checksum "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704239a0bc1ffc9fb9ce230d19a3eb7f444061f1"
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
#line 1 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detalles/editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Fecha\r\n        </label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-10");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputDate_0(__builder2, 16, 17, 
#nullable restore
#line 15 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                    Modelo.Fecha

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Fecha = __value, Modelo.Fecha)), 19, () => Modelo.Fecha);
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Tiempo\r\n        </label>\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-10");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputNumber_1(__builder2, 30, 31, 
#nullable restore
#line 24 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                      Modelo.Tiempo

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Tiempo = __value, Modelo.Tiempo)), 33, () => Modelo.Tiempo);
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "mb-3");
                __builder2.AddMarkupContent(39, "\r\n        Recurso:\r\n        ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputSelect_2(__builder2, 40, 41, "p-1", 42, 
#nullable restore
#line 30 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                              RecursoId

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecursoId = __value, RecursoId)), 44, () => RecursoId, 45, (__builder3) => {
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.AddMarkupContent(47, "<option value=\"0\">Elija un Recurso</option>\r\n");
#nullable restore
#line 32 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
             foreach (var item in Recursos)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "                ");
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 34 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 34 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                          item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n");
#nullable restore
#line 35 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(53, "        ");
                }
                );
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "mb-3");
                __builder2.AddMarkupContent(58, "\r\n        Tarea:\r\n        ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputSelect_3(__builder2, 59, 60, "p-1", 61, 
#nullable restore
#line 41 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                              TareaId

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TareaId = __value, TareaId)), 63, () => TareaId, 64, (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.AddMarkupContent(66, "<option value=\"0\">Elija un Recurso</option>\r\n");
#nullable restore
#line 43 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
             foreach (var item in Tareas)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                ");
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "value", 
#nullable restore
#line 45 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(70, 
#nullable restore
#line 45 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
                                          item.Titulo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n");
#nullable restore
#line 46 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(72, "        ");
                }
                );
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n    ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\">Guardar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Tamara\Desktop\davinci\17 - Plataformas de desarrollo\repo\20201103\BlazorApp1\Pages\Detalles\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Detalle Modelo { get; set; } = new Detalle();

    public string RecursoId { get; set; }

    private List<Recurso> Recursos;

    public string TareaId { get; set; }

    private List<Tarea> Tareas;

    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Modelo = await service.Get(Id);
        }
        else
        {
            Modelo = new Detalle();
        }
    }


    private async void Guardar()
    {
        await service.Save(Modelo);
        navigation.NavigateTo("detalles/listado");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService service { get; set; }
    }
}
namespace __Blazor.BlazorApp1.Pages.Detalles.Editar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

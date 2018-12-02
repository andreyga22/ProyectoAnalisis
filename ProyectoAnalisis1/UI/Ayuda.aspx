<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="Ayuda.aspx.cs" Inherits="UI.Ayuda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Ayuda del sistema" Font-Size="XX-Large"></asp:Label>
        </div>



        <div class="accordion" id="accordionExample">
            <div class="card">
                <div class="card-header" id="headingOne">
                    <h5 class="mb-0">
                        <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                            Crear nuevo expediente
                        </button>
                    </h5>
                </div>

                <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#accordionExample">
                    <div class="card-body">
                        <ol type="1">
                            <li>En la página principal, dé click en el botón "Crear nuevo expediente"</li>
                            <li>Complete la información necesaria del paciente.</li>
                            <li>Dé click en el botón "Guardar"</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingTwo">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                            Buscar un expediente
                        </button>
                    </h5>
                </div>
                <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionExample">
                    <div class="card-body">
                        <ol type="1">
                            <li>Diríjase a la página principal, en la sección "Buscar Expedientes"</li>
                            <li>Los expedientes se pueden buscar por "Cédula" o por "Nombre"</li>
                            <li>En busqueda por cédula: Digíte la cédula completa o parte de esta en el campo "Buscar por Cédula" y dé click en el botón buscar.</li>
                            <li>En busqueda por nombre: Digíte el nombre completo o parte de éste en el campo "Buscar por Nombre" y dé click en el botón buscar.</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingThree">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                            Ver todos los Expedientes
                        </button>
                    </h5>
                </div>
                <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>En la página principal, seleccione el botón "Todos Expedientes"</li>
                            <li>Ridirige a la página donde se encuentran en una tabla en la sección "Expedientes" donde se encuentran ordenados alfabéticamente por el primer apellido del paciente</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingFour">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
                            Filtrar expediente por Rango de fechas de las consultas
                        </button>
                    </h5>
                </div>
                <div id="collapseFour" class="collapse" aria-labelledby="headingFour" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>En la página principal, seleccione el botón "Todos Expedientes"</li>
                            <li>Ridirige a otra página donde se encuentran dos calendarios de fecha inicio y de fecha fin</li>
                             <li>Seleccionar el rango de fechas por el que se desea filtrar</li>
                             <li>Dar click en el botón de filtrar</li>
                             <li>El resultado de la búsqueda se puede observar en la tabla de la sección Expedientes, sino encuentra ningún expediente con consultas en ese rango de fechas muestra un mensaje informando el error</li>
                        </ol>
                    </div>
                </div>
            </div>
             <div class="card">
                <div class="card-header" id="headingFive">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseFive" aria-expanded="false" aria-controls="collapseFive">
                            Agregar expedientes a la lista del día
                        </button>
                    </h5>
                </div>
                <div id="collapseFive" class="collapse" aria-labelledby="headingFive" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Opción 1: En la página principal, puede realizar una búsqueda por cédula o nombre y en la tabla darle click a "Agregar"</li>
                            <li>Opción 2: En la página donde se encuentran todos los expedientes, en la tabla de la sección Expedientes darle click a "Agregar" en la fila del expediente que desea agregar</li>
                            <li>Opción 3: En la página donde se encuentran las listas de consultas del expediente, darle click al botón de "Agregar" y dicho expediente se agrega automáticamente a la lista del día</li>
                        </ol>
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-header" id="headingSix">
                    <h5 class="mb-0">
                        <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseSix" aria-expanded="false" aria-controls="collapseSix">
                            Crear una nueva consulta
                        </button>
                    </h5>
                </div>
                <div id="collapseSix" class="collapse" aria-labelledby="headingSix" data-parent="#accordionExample">
                    <div class="card-body">
                         <ol type="1">
                            <li>Seleccionar el expediente al que se desea agregar la consulta</li>
                            <li>Darle click al botón de "Consultas" donde se pueden observar las consultas que tiene al momento el paciente</li>
                            <li>Dar click en el botón "Agregar"</li>
                            <li>Redirige a la página de la consulta donde se pueden realizar las modificaciones necesarias</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>





    </div>

</asp:Content>

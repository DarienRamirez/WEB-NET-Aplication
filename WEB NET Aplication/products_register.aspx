<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="products_register.aspx.cs" Inherits="WEB_NET_Aplication.products_register" enableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form runat=server>
        <main>
            <div class="container-fluid">

          <!-- Section: Inputs -->
          <section class="section card mb-5">
            <div class="card text-center">
              <h3 class="card-header light-green white-text">Registro de Productos</h3>
            <div class="card-body">
              <div class="row">
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_nombre" runat="server" class="form-control" type="text" ></asp:TextBox>
                    <label for="form1" class="">Nombre</label>
                  </div>
                </div>
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_price" runat="server" class="form-control" type="number" ></asp:TextBox>

                    <label for="form1" class="">Precio</label>
                  </div>
                </div>
                <div class="col-md-4 mb-4">
                  <div class="md-form">
                      <asp:TextBox id="txt_rate" runat="server" class="form-control" type="number" ></asp:TextBox>
                    <label for="form1" class="">Calificacion</label>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-lg-6 col-md-6 mb-4">
                    <asp:DropDownList runat="server" class="mdb-select md-form" id="dd_type"></asp:DropDownList>
                </div>
                <div class="col-lg-6 col-md-6">
                    <asp:DropDownList runat="server" class="mdb-select md-form" id="dd_color"></asp:DropDownList>
                </div>
              </div>
              <div class="row text-left">
                <div class="col-md-12">
                  <div class="md-form">
                      <asp:TextBox id="txt_description" runat="server" class="md-textarea form-control" type="text" rows="2"></asp:TextBox>

                    <label for="form10">Descripcion</label>
                  </div>
                </div>
              </div>
              <div class="row">
                <div class="col-md-12 mb-6">
                  <form>
                    <div class="md-form">
                      <div class="file-field">
                        <div class="row">
                            <asp:Button runat="server" class="btn btn-light-green btn-sm float-left" text="Selecionar Imagen" id="btn_uploadimg"/>
                            <asp:FileUpload runat="server" id="file_img"></asp:FileUpload>
                        </div>
                      </div>
                    </div>
                  </form>
                </div>
              </div>
              <hr></hr>
              <div class="col-lg-12 col-md-12 mb-12">
                <div class="card-foter text-right">
                    <asp:Button runat="server" Text="Registrar" class="btn btn-light-green waves-effect waves-light" style="width: 140px;" onClick="Register" />
                </div>
              </div>
            </div>
          </div>
          </section>
        </div>
       </main>
    </form>
</asp:Content>

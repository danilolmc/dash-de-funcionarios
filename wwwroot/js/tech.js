$(function () {


  $("#modal").hide();

  $("#btnAddTech").on("click", () => {
    $("#modal").fadeIn();
  });

  $("#formtech").on("submit", (e) => {
    e.preventDefault();
    EnviarDados();
  });

  $("#formtechEdit").on("submit", (e) => {
    e.preventDefault();
    EnviarDadosAtualizar();
  });

  $("#modal").on("click", (e) => {
    if (e.target.id == "modal") {
      $("#formtech").reset();

      $(e.target).fadeOut();
    }
  });
});

function EnviarDados() {
  let formulario = document.getElementById("formtech");

  const form = new FormData(formulario);

  $.ajax({
    url: "https://localhost:5001/wa/tecnologias/cadastrar/salvaralteracoes",
    type: "post",
    data: form,
    processData: false,
    contentType: false,
  }).done((response) => {
    if (response == "1") {
      $("#error").text("Tecnologia cadastrada com sucesso");
      $("#error").css("color", "green");
      $("#error").fadeIn();

      setTimeout(
        () => (window.location = window.location.origin + "/wa/tecnologias"),
        2000
      );
    } else {
      $("#error").text("Não foi possível cadastrar, tente novamente!");
      $("#error").css("color", "red");
      $("#error").fadeIn();
    }
  });
}

$(function () {
  let btnSelecionar = $(".btnSelecionar");
  let formAlocacao = $("#formAlocacao");
  let vagas = $(".vaga");
  let inputidVaga = $("#txtidVaga");
  let selecionado = false;

  btnSelecionar.on("click", (e) => {
    inputidVaga.val(e.target.value);

    if (!selecionado) {
      for (const vaga of vagas) {
        vaga.style.pointerEvents = "none";
        vaga.style.opacity = 0.5;
      }

      e.target.parentElement.parentElement.style.opacity = 1;
      e.target.parentElement.parentElement.style.backgroundColor = "#3b67c71f";
      e.target.parentElement.parentElement.style.pointerEvents = "all";

      selecionado = true;

      if ((formAlocacao.css = "none")) {
        formAlocacao.fadeIn();
      }
    } else {
      for (const vaga of vagas) {
        vaga.style.pointerEvents = "all";
        vaga.style.opacity = 1;
        
      }
      e.target.parentElement.parentElement.style.backgroundColor = "#fff";
      selecionado = false;
      formAlocacao.fadeOut();
    }
  });
});

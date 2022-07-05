const queryString = window.location.search;

const urlParams = new URLSearchParams(queryString);

const Data = urlParams.get('Data')

document.getElementsByClassName("ClsSel40Bis").Data.value = Data;
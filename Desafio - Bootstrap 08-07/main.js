function returnTable(){
    document.getElementById('table-name').innerHTML = document.getElementById('name').value;
    document.getElementById('table-surname').innerHTML = document.getElementById('surname').value;
    document.getElementById('table-email').innerHTML = document.getElementById('email').value;
    document.getElementById('table-login').innerHTML = document.getElementById('login').value;
    document.getElementById('table-password').innerHTML = document.getElementById('password').value;
    document.getElementById('table-gender').innerHTML = document.querySelector('input[name="genderRadio"]:checked').value;

    var cbxState = document.getElementById('state');
    document.getElementById('table-state').innerHTML = cbxState.options[cbxState.selectedIndex].text;
    document.getElementById('table-city').innerHTML = document.getElementById('city').value;
    document.getElementById('table-cep').innerHTML = document.getElementById('cep').value;
    document.getElementById('table-district').innerHTML = document.getElementById('district').value;
    document.getElementById('table-address').innerHTML = document.getElementById('address').value;
    document.getElementById('table-complement').innerHTML = document.getElementById('complement').value;

    document.getElementById('table-github').innerHTML = document.getElementById('github').value;
    var cbxCourse = document.getElementById('course');
    document.getElementById('table-course').innerHTML = cbxCourse.options[cbxCourse.selectedIndex].text;
    var cbxProfessor = document.getElementById('professor');
    document.getElementById('table-professor').innerHTML = cbxProfessor.options[cbxProfessor.selectedIndex].text;

    document.getElementById('table-terms').innerHTML = document.getElementById('terms').value == 'on' ? 'Aceito' : 'Rejeitado';
    document.getElementById('table-info').innerHTML = document.querySelector('input[name=information]:checked') == 'on' ? 'Sim' : 'Não';

    alert("Formulário enviado com sucesso!");
    document.getElementById('mainForm').reset();
};

function getLocation(){
    
    const cep = document.getElementById('cep').value;

    if(cep != ""){

        fetch(`https://viacep.com.br/ws/${cep}/json/`).then((response)=> {
            if (response.status >= 200 && response.status <= 299) {
                return response.json();
            } else {
                throw error(response.statusText);
            }
        })
        .then((jsonResponse) => {
            if(!jsonResponse.hasOwnProperty('erro')){
                document.getElementById('state').value = jsonResponse.uf;
                document.getElementById('city').value = jsonResponse.localidade;
                document.getElementById('district').value = jsonResponse.bairro;
                document.getElementById('address').value = jsonResponse.logradouro;
                document.getElementById('complement').value = jsonResponse.complemento;                
            }
            else{
                alert('CEP não encontrado. Verifique CEP informado!');       
                clearLocation();                             
            }
        })
        .catch((error) => {
            alert("API retornou erro (" + error + ") Verifique CEP informado!");
            clearLocation();
        })
    }
} 

function clearLocation(){
    document.getElementById('city').value = "";   
    document.getElementById('district').value = "";   
    document.getElementById('address').value = "";   
    document.getElementById('complement').value = "";   
    document.getElementById('state').value = "";   
    document.getElementById('cep').value = "";  
}
    
function createLogin(){
    const l_name= document.getElementById('name').value;
    const l_surname = document.getElementById('surname').value;
    const login = l_name + '.' + l_surname;
    document.getElementById('login').value = login.toLowerCase();
}

function unlockAcept(){
    var terms = document.getElementById('terms_text');
    if((terms.scrollTop + terms.offsetHeight) >= terms.scrollHeight){
        document.getElementById('terms').removeAttribute('disabled');
    }
}

document.getElementById('mainForm').addEventListener('submit',function(e){
    e.preventDefault();
    document.getElementById('return-table').classList.remove('d-none');
    returnTable();
});

document.getElementById('name').addEventListener('keyup',createLogin);
document.getElementById('surname').addEventListener('keyup',createLogin);
document.getElementById('cep').addEventListener('focusout',getLocation);
document.getElementById('terms_text').addEventListener('scroll',unlockAcept);

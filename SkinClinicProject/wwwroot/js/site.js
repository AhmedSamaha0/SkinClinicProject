// ===> Elements <===

const { isNumeric } = require("jquery");

//=>> Inputs
let inpName = document.getElementById("full-name");
let inpPhoneNumber = document.getElementById("phone-number");
let inpEmail = document.getElementById("email");
let inpPassword = document.getElementById("password");
let inpConfirmPassword = document.getElementById("confirm-password");
let inpBirthDate = document.getElementById("birth-date");
let inpAddress = document.getElementById("address");

//=>> Span Validation
let validInpName = document.getElementById("valid-full-name");
let validInpPhoneNumber = document.getElementById("valid-phone-number");
let validInpEmail = document.getElementById("valid-email");
let validInpPassword = document.getElementById("valid-password");
let validInpConfirmPassword = document.getElementById("valid-confirm-password");
let validInpBirthDate = document.getElementById("valid-birth-date");
let validInpAddress = document.getElementById("valid-address");
//Validation Full Name

// Functions Validations
function validName() {
    if (inpName != null) {

        let sizeOfName = inpName.value.length;
        if (sizeOfName >= 2) {



        } else {
            validInpName.textContent = "الاسم لا يقل عن حرفين";
        }
         
    } else {
        validInpName.textContent = "برجاء ادخال اسمك";
    }
}

function validPassword() {

    let pass = inpPassword.value
    let sizeOFPassword = pass.length;
    if (sizeOFPassword >= 6) {

        let checkNumber = false;
        let checkSmall = false;
        let checkCaptial = false;
        let checkCharcter = false;

    } else {
        validInpPassword.textContent = "الرقم السري لايقل عن 6 حروف";
    }
    
}

// Exetions Functions

function isNumber(num) {
    return isNaN(parseInt(num)) ? false : true;
}

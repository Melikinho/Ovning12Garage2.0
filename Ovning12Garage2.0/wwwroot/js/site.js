


var button = document.getElementById("myButton");
var Receipt = document.getElementById('myReceipt')
var span = document.getElementsByClassName("close")[0];

        button.onclick = function() {
            myReceipt.style.display = "block";
        }

            span.onclick = function() {
                myReceipt.style.display = "none";
            }

        window.onclick = function (event) {
            if (event.target == myReceipt) {
                myReceipt.style.display = "none";
                    }
                }
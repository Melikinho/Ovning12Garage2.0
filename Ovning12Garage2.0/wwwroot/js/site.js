﻿
    var receipt = document.getElementById("myReceipt");

    var button = document.getElementById("myButton");

        var span = document.getElementsByClassName("close")[0];

        button.onclick = function() {
            receipt.style.display = "block";
        }

            span.onclick = function() {
                receipt.style.display = "none";
            }

            window.onclick = function(event) {
                if (event.target == receipt) {
                    receipt.style.display = "none";
                }
            }
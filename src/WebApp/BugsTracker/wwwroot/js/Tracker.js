
function AttachModalCreateListener(createBtnId, url, modalLarge = false, isTicket = false) {
    createBtnId.on('click', function () {
        $.ajax({
            type: "GET",
            url: url,
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            success: function (result) {
                $(' #modal-holder .modal-content').html(result);
                $("#modal-holder").modal("show");
                $("#modal-holder").removeClass("right");

                handleModalSize(modalLarge);

                $.validator.setDefaults({ ignore: [] });

                if (isTicket) {
                    setTicketTabsListener();
                    addTicketHandler();
                    $('[data-toggle="popover"]').popover()                }
            },
            error: function (data) {
                alert("Error loading dynamic data");
                console.log(data)
            }
        });
    });
}

function AttachTableModalListeners(buttons, url, getName = false, modalLarge = false, ticketUpdate = false) {
    buttons.forEach((btn) => {
        $(btn).on('click', () => {
            let parentContainer = btn.closest("tr");
            let targetId = parentContainer.querySelector(".d-none").innerText;

            if (getName === true) {
                var name = parentContainer.querySelector(".text-purple a.ticket-link").innerText;
            }

            $.ajax({
                type: "GET",
                url: url,
                contentType: "application/json; charset=utf-8",
                data: (getName === true) ? { id: targetId, name: name } : { id: targetId },
                datatype: "json",
                success: function (result) {
                    $("#modal-holder").modal("show")
                    $('#modal-holder .modal-content').html(result);
                    $("#modal-holder").removeClass("right");

                    handleModalSize(modalLarge);

                    $.validator.setDefaults({ ignore: [] });

                    if (ticketUpdate) {
                        setTicketTabsListener();
                        setSelectCleaner();
                        addTicketHandler();
                    }
                },
                error: function (data) {
                    console.log(data)
                }
            });
        })
    })
}

function AttachProjectUpdateModalListener(button, url, modalLarge) {
    $(button).on('click', () => {
        $.ajax({
            type: "GET",
            url: url,
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            success: function (result) {
                $("#modal-holder").modal("show")
                $('#modal-holder .modal-content').html(result);
                $("#modal-holder").removeClass("right");

                handleModalSize(modalLarge);
                setProjectTabListener();
                setSelectCleaner();
                $.validator.setDefaults({ ignore: [] });
            },
            error: function (data) {
                console.log(data)
            }
        });
    })

}

function setProjectTabListener() {
    var tabs = ['.project-details-tab', '.project-organization-tab'];

    for (var i = 0; i < tabs.length; i++) {

        if (i == 0) {
            let tick = i; 
            $(tabs[tick]).click(() => {
                $(tabs[tick] + " a").addClass("active");
                $(tabs[tick + 1] + " a").removeClass("active");

                $(tabs[tick].replace("-tab", "")).removeClass("d-none");
                $(tabs[tick+1].replace("-tab", "")).addClass("d-none");
            });
        }
        else {
            let tick = i;
            $(tabs[tick]).click(() => {
                $(tabs[tick] + " a").addClass("active");
                $(tabs[tick - 1] + " a").removeClass("active");

                $(tabs[tick].replace("-tab", "")).removeClass("d-none");
                $(tabs[tick - 1].replace("-tab", "")).addClass("d-none");
                console.log(tick)

            });
        }

    }

}

function setTicketTabsListener() {
    $(".crupdate-ticket-tabs .nav-item").click(function (e) {
        $(".crupdate-ticket-tabs .nav-item .nav-link.active").removeClass("active");
        e.target.classList.add("active");
        if (e.currentTarget.children[0].firstChild.data === "Ticket") {
            $("#ticket-configuration").removeClass("d-none");
            $("#ticket-team").addClass("d-none");
        }
        else {
            $("#ticket-configuration").addClass("d-none");
            $("#ticket-team").removeClass("d-none");

        }
    })

}

function setSelectCleaner() {
    $(".select-cleaner").click(function (e) {
        var closestSelectId = e.target.closest("div").parentElement.nextElementSibling.id;
        var targets = $("#" + closestSelectId + " option");

        for (var i = 0; i < targets.length; i++) {
            targets[i].removeAttribute("selected");
        }
    });

}

function setCoverListeners() {
    var imageInput = document.getElementById("cover-input");
    var imageBtn = document.getElementById("cover-btn");
    var imagePreview = document.getElementById("image-preview");
    var imagePreviewImg = document.querySelector(".image-preview__image");
    var imagePreviewText = document.querySelector(".image-preview__text");


    imageBtn.addEventListener("click", () => {
        imageInput.click();
    });
    imageInput.addEventListener("change", () => {
        const file = imageInput.files[0];

        if (file) {
            // Make sure `file.name` matches our extensions criteria

            if (!/\.(jpe?g|png)$/i.test(file.name)) {
                return alert(file.name + " is not an image");
            }
            const reader = new FileReader();

            imagePreview.style.border = "none";
            imagePreviewText.style.display = "none";
            imagePreviewImg.style.display = "block";

            reader.onload = function (e) {
                imagePreviewImg.setAttribute("src", e.target.result.toString());
            }
            reader.readAsDataURL(file);

        }
    });
}

function handleModalSize(modalLarge) {
    if (modalLarge) {
        $(".modal-dialog")[0].classList.add("modal-dialog-large")
    }
    else {
        if ($(".modal-dialog")[0].classList.contains("modal-dialog-large")) {
            $(".modal-dialog")[0].classList.remove("modal-dialog-large")
        }
    }
}

function addTicketHandler() {
    setTicketTabsListener();
    setSelectCleaner();
    $(".ticket-save-btn").click(function () { if (!$("form").valid()) { revealTicketFormErrors(); } });

}

function revealTicketFormErrors() {
    var validator = $("form").validate();
    validator.showErrors();
    $("#ticket-configuration").removeClass("d-none");
    $("#ticket-team").addClass("d-none");
    $(".team-tab .nav-link").removeClass("active");
    $(".configuration-tab .nav-link").addClass("active")
}


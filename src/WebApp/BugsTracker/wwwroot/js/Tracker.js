function AttachModalCreateListener(createBtnId, url, modalLarge, data) {
    createBtnId.on('click', function () {
        console.log(data)
        var options = { "backdrop": "static", keyboard: true };
        $.ajax({
            type: "GET",
            url: url,
            data: jQuery.param({ projectId: data }),
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            success: function (result) {
                $(' #modal-holder .modal-content').html(result);
                if (modalLarge) {
                    $(".modal-dialog")[0].classList.add("modal-dialog-large")
                }
                $("#modal-holder").modal("show")
            },
            error: function (data) {
                alert("Error loading dynamic data");
                console.log(data)
            }
        });
    });
}

function AttachTableModalListeners(buttons, url) {
    buttons.forEach((btn) => {
        $(btn).on('click', () => {
            let parentContainer = btn.closest("tr");
            let targetId = parentContainer.querySelector(".d-none").innerText;
            $.ajax({
                type: "GET",
                url: url,
                contentType: "application/json; charset=utf-8",
                data: { Id: targetId },
                datatype: "json",
                success: function (result) {
                    $("#modal-holder").modal("show")
                    $('#modal-holder .modal-content').html(result);
                },
                error: function (data) {
                    console.log(data)
                }
            });
        })
    })
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
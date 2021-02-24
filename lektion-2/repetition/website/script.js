fetch('https://win20-recapapi.azurewebsites.net/api/products/1')
    .then(res => res.json())
    .then(data => {
        document.getElementById('shortDescription').innerHTML = data.shortDescription
        document.getElementById('name').innerHTML = data.name
        document.getElementById('longDescription').innerHTML = data.longDescription
        document.getElementById('price').innerHTML = `Pris ${data.price} kr`
    })
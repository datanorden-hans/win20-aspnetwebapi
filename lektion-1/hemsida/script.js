let userhtml = document.getElementById('user');
let usershtml = document.getElementById('users');

fetch('https://localhost:44357/api/Customers')
    .then(res => res.json())
    .then(data => {
        
        for(let user of data) {
            let li = document.createElement('li')

            li.innerText = `${user.displayName} (${user.id})`
            usershtml.appendChild(li)         


        }      
    })

fetch('https://localhost:44357/api/Customers/8ccece9d-d0ca-496e-969d-76bea747805c')
    .then(res => res.json())
    .then(data => userhtml.innerText = data.displayName)
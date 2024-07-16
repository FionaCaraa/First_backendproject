@*
    document.addEventListener('DOMContentLoaded', function () {
        fetch('/api/products')
            .then(response => response.json())
            .then(products => {
                const productContainer = document.getElementById('products');

                products.forEach(product => {
                    const productCard = document.createElement('div');
                    productCard.className = 'product-card';

                    productCard.innerHTML = `
                    <img src="${product.image || 'default-image.jpg'}" alt="${product.name}">
                    <div class="product-details">
                        <h3>Kategori Adı: ${product.category.name}</h3>
                        <p>Ürün Adı: ${product.name}</p>
                        <p>Fiyat: ${product.price}</p>
                        <p>Açıklama: ${product.description}</p>
                        <button class="detail-button" onclick="showDetails('${product.name}')">Detay</button>
                    </div>
                `;

                    productContainer.appendChild(productCard);
                });
            })
            .catch(error => console.error('Error fetching products:', error));
    });

function showDetails(productName) {
    alert('Detayları göster: ' + productName);
}

*@
@{
}

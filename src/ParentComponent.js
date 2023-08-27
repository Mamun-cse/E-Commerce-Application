// ParentComponent.js

import React, { useState } from 'react';
import ProductList from './ProductList';
import ProductDetails from './ProductDetails';

const ParentComponent = () => {
  const [selectedProduct, setSelectedProduct] = useState(null);

  const handleProductClick = (product) => {
    setSelectedProduct(product);
  };

  const handleModalClose = () => {
    setSelectedProduct(null);
  };

  return (
    <div>
      <h1>Product List</h1>
      <ProductList onProductClick={handleProductClick} />

      {selectedProduct && (
        <ProductDetails
          product={selectedProduct}
          addToCart={(product) => console.log('Add to cart:', product)}
          onClose={handleModalClose}
        />
      )}
    </div>
  );
};

export default ParentComponent;

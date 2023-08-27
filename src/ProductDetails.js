import React from 'react';
import Modal from 'react-modal';
import 'bootstrap/dist/css/bootstrap.min.css'; // Import Bootstrap CSS
import './ProductDetails.css';
const ProductDetails = ({ product, addToCart, onClose }) => {
  return (
    <Modal
      isOpen={true}
      onRequestClose={onClose}
      className="modal-dialog modal-dialog-centered"
    >
      <div class="container">
      <div className="modal-content">
        <div className="modal-header">
          <h5 className="modal-title">{product.productName}</h5>
          <button type="button" className="close" onClick={onClose}>
            <span aria-hidden="true">&times;</span>
          </button>
        </div>
        <div className="modal-body">
          <img src={product.imageUrl} alt={product.productName} className="img-fluid rounded" />
          <p className="mt-3">Price: ${product.price}</p>
          <h5 className="mt-3">{product.productDescription}</h5>
        </div>
        <div className="modal-footer">
          <button className="btn btn-primary" onClick={() => addToCart(product)}>
            Add to Cart
          </button>
          <button className="btn btn-secondary" onClick={onClose}>
            Close
          </button>
        </div>
      </div>
      </div>
    </Modal>
  );
};

export default ProductDetails;

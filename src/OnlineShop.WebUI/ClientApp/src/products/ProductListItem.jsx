import React from 'react';
import { Card, CardBody, CardTitle, Button, CardSubtitle } from 'reactstrap';
import './ProductListItem.css';
import { Link } from 'react-router-dom';
import { useCartUpdate } from '../cart/CartContext';

const ProductListItem = ({ product }) => {
  const addProduct = useCartUpdate();

  return (
    <Card>
      <img alt="product" src={product.imageUrl} />
      <CardBody>
        <CardTitle tag="h5">{product.name}</CardTitle>
        <CardSubtitle>Price: ${product.price}</CardSubtitle>
        <div className="button-wrapper">
          <Button color="primary" onClick={addProduct}>
            Add to Cart
          </Button>
          <Link className="btn btn-secondary" to={`/product/${product.id}`}>
            Details
          </Link>
        </div>
      </CardBody>
    </Card>
  );
};

export default ProductListItem;

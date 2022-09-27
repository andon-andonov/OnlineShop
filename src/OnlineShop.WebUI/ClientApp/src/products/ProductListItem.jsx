import React from 'react';
import { Card, CardBody, CardTitle, Button, CardSubtitle } from 'reactstrap';

const ProductListItem = ({ product }) => {
  return (
    <Card style={{ width: '18rem' }}>
      <img src="{product.imageUrl}" />
      <CardBody>
        <CardTitle tag="h5">{product.name}</CardTitle>
        <CardSubtitle>Price: ${product.price}</CardSubtitle>
        <Button color="primary">Add to Cart</Button>
        <Button>Details</Button>
      </CardBody>
    </Card>
  );
};

export default ProductListItem;

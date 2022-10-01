import { useEffect, useState } from 'react';
import { useParams, Link } from 'react-router-dom';
import { getProduct } from './ProductsApi';
import {
  Card,
  CardBody,
  CardTitle,
  CardText,
  CardSubtitle,
  Button,
  CardImg,
} from 'reactstrap';
import { useCartUpdate } from '../cart/CartContext';

const ProductDetails = () => {
  let { id } = useParams();
  const [product, setProduct] = useState([]);
  const [loaded, setLoaded] = useState(false);
  const addProduct = useCartUpdate();

  useEffect(() => {
    getProduct(id).then((product) => {
      setProduct(product);
      setLoaded(true);
    });
  }, [id]);

  return loaded ? (
    <Card style={{ width: '100%' }}>
      <CardBody>
        <CardTitle tag="h1">{product.name}</CardTitle>
        <CardImg
          alt="p"
          src={product.imageUrl}
          style={{
            height: 180,
          }}
          width="100%"
        />
        <CardSubtitle>Price: ${product.price}</CardSubtitle>
        <CardText>{product.description}</CardText>
        <Button color="primary" onClick={addProduct}>
          Add to Cart
        </Button>
        <Link className="btn btn-secondary" to="/">
          Back
        </Link>
      </CardBody>
    </Card>
  ) : (
    <div>Loading</div>
  );
};

export default ProductDetails;

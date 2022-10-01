import { useCart } from './CartContext';

const CartCount = () => {
  const cart = useCart();
  return <div>{cart}</div>;
};

export default CartCount;

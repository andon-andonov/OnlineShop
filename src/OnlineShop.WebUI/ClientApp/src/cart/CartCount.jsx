import { useCart } from './CartContext';

const CartCount = () => {
  const cart = useCart();
  return <>{cart}</>;
};

export default CartCount;

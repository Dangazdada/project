import { useEffect,useState } from 'react';
import _ from 'lodash';
import axiosClient from '../Component/axiosClient';
import {baseURL} from '../Component/axiosClient';
import $ from 'jquery';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../Component/auth';


const HeroSection = () => {
      const [ProductTypes, setProductTypes] = useState([]);
      const [Products, setProduct] = useState([]);
      const [Combos, setCombos] = useState([]);//đây 
      const navigate =  useNavigate();
      const {  userId } = useAuth();
      const [cart, setCart] = useState([]);
      
      useEffect(() => {
          axiosClient.get(`/ProductTypes`)
          .then(res =>setProductTypes(res.data));
          axiosClient.get(`/Products`)
          .then(res => {
            setProduct(res.data);
          });//đây 
          axiosClient.get(`/Comboes`).then((res) => {
            setCombos(res.data);
          });//đây 
          
          $('.set-bg').each(function () {
              var bg = $(this).data('setbg');
              $(this).css('background-image', 'url(' + bg + ')');
          });
          
          $(".humberger__open").on('click', function () {
              $(".humberger__menu__wrapper").addClass("show__humberger__menu__wrapper");
              $(".humberger__menu__overlay").addClass("active");
              $("body").addClass("over_hid");
          });
      
          $(".humberger__menu__overlay").on('click', function () {
              $(".humberger__menu__wrapper").removeClass("show__humberger__menu__wrapper");
              $(".humberger__menu__overlay").removeClass("active");
              $("body").removeClass("over_hid");
          });
          $('.hero__categories__all').on('click', function(){
              $('.hero__categories ul').slideToggle(400);
          });
      
        },[]);
        const allItems = [...Products, ...Combos];//đây 
        const shuffledProducts = _.shuffle(allItems);//đây 
        const selectedProducts = shuffledProducts.slice(0, 1);
        useEffect(() => {
          const fetchData = async () => {
              try {
                  
                  const cartResponse = await  axiosClient.get(`/Carts/userId`, {
                    params: { userId: encodeURIComponent(userId) }
                })
                setCart(cartResponse.data);
              } catch (error) {
                  console.error('Lỗi khi lấy dữ liệu:', error);
              }
          };
      
          // Gọi hàm fetchData khi component được mount
          fetchData();
      }, [userId]);
        const handleAddToCart =  (productId,productSku) => {
          //const cartItem = cart.find(a => a.product.id === productId);
          //const foundCartItem = cart.find(a => a.product.id === productId && a.combo.productType.name === comboName);
          let cartItem =null;
          if(productSku == undefined){
              cartItem = cart.find(a => a.comboId === productId);
          }else{
              cartItem = cart.find(a => a.productId === productId);
          }
          console.log('cartItem',cartItem)
      
          let foundProduct = false;
          
          if (cartItem) {
              
          
              let idP = cartItem.productId;
              let idC = cartItem.comboId;
              let id  = cartItem.id;
              if(idP  === productId && productSku != undefined)
              {
                  foundProduct =true;
                  const updateItem = { ...cartItem, quantity: cartItem.quantity  + 1};
                  try{
                      
                      axiosClient.put(`/Carts/${id}`, updateItem)
                      .then(() => navigate('/Shop/cart'));
                  }
                  catch
                  {
                  console.log('lỗi khi thêm vào giỏ hàng')
                  }
                  
              }else if(idC  === productId && productSku == undefined)
              {
                  foundProduct =true;
                  const updateItem = { ...cartItem, quantity: cartItem.quantity  + 1};
                  try{
                      
                      axiosClient.put(`/Carts/${id}`, updateItem)
                      .then(() => navigate('/Shop/cart'));
                  }
                  catch
                  {
                  console.log('lỗi khi thêm vào giỏ hàng')
                  }
              }
              }
      
              if (!foundProduct) {
                  const cart = {
                  userId: userId,
                  productId: productSku !== undefined ? productId : null,
                  ComboId: productSku !== undefined ? null :productId,
                  quantity: 1
                  };
              
                  axiosClient.post(`/Carts`, cart)
                  .then(() => {
                      console.log('Product added successfully');
                  })
                  .catch((error) => {
                      console.error('Error adding product to cart:', error);
                      console.log('lỗi khi thêm vào giỏ hàng');
                  });
              }
          };
      return (
        <section className="hero">
          <div className="container">
            <div className="row">
              <div className="col-lg-3">
                <div className="hero__categories">
                  <div className="hero__categories__all">
                    <i className="fa fa-bars"></i>
                    <span>Thực đơn</span>
                  </div>
                  <ul>
                  
                    {ProductTypes.map
                    ((producttypes,index) =>(
                      <li key={index}><a href={`/Shop/categori/${producttypes.id}`}> {producttypes.name}</a></li>
                    ))
                    }
                  </ul>
                </div>
              </div>
              {selectedProducts.map
                ((product,index) =>(
                <div key={index} className="col-lg-9">
                  <div className="hero__item set-bg" data-setbg={`${baseURL}/Images/${product.images.img}`}
                      style={{width:'100%', backgroundImage: `url(${baseURL}/Images/${product.images.img})` }}>
                    <div className="hero__text">
                    <span>Đặt Món Nhanh</span>
                      <h2>{product.name}</h2>
                      <p>Giá {product.price.toLocaleString('vi-VN')} vnđ</p>
                      <a href="/Shop/topay" onClick={() => handleAddToCart(product.id,product.sku)} className="primary-btn">Đặt món ngay</a>
                    </div>
                  </div>
                  </div>
                ))
              }
            </div>
          </div>
        </section>
      );
    };
    
    export default HeroSection;

// import { useEffect,useState } from 'react';
// import _ from 'lodash';
// import axios from 'axios';
// import $ from 'jquery';


// const HeroSection = () => {
//     const [ProductTypes, setProductTypes] = useState([]);
//     const [Products, setProduct] = useState([]);
//     const [isDataLoaded, setIsDataLoaded] = useState(false);
//     useEffect(() => {
//         axios.get(`${baseURL}/api/ProductTypes`)
//         .then(res =>setProductTypes(res.data));
//         axios.get(`${baseURL}/api/Products`)
//         .then(res => {
//           setProduct(res.data);
//           setIsDataLoaded(true);
//         });
//         $('.set-bg').each(function () {
//             var bg = $(this).data('setbg');
//             $(this).css('background-image', 'url(' + bg + ')');
//         });
        
//         $(".humberger__open").on('click', function () {
//             $(".humberger__menu__wrapper").addClass("show__humberger__menu__wrapper");
//             $(".humberger__menu__overlay").addClass("active");
//             $("body").addClass("over_hid");
//         });
    
//         $(".humberger__menu__overlay").on('click', function () {
//             $(".humberger__menu__wrapper").removeClass("show__humberger__menu__wrapper");
//             $(".humberger__menu__overlay").removeClass("active");
//             $("body").removeClass("over_hid");
//         });
//         $('.hero__categories__all').on('click', function(){
//             $('.hero__categories ul').slideToggle(400);
//         });
    
//       },[isDataLoaded]);
//       let shuffledProducts = _.shuffle(Products);

//   // Chọn 8 sản phẩm đầu tiên
//       let selectedProducts = shuffledProducts.slice(0, 1);
//       if (isDataLoaded) {
//       const shuffledProducts = _.shuffle(Products);

//       // Chọn 8 sản phẩm đầu tiên
//       const selectedProducts = shuffledProducts.slice(0, 1);
//       }
//     return (
//       <section className="hero">
//         <div className="container">
//           <div className="row">
//             <div className="col-lg-3">
//               <div className="hero__categories">
//                 <div className="hero__categories__all">
//                   <i className="fa fa-bars"></i>
//                   <span>Thực đơn</span>
//                 </div>
//                 <ul>
                
//                   {ProductTypes.map
//                   ((producttypes,index) =>(
//                     <li key={index}><a href={`/Shop/MATheothucdon/${producttypes.id}`}> {producttypes.name}</a></li>
//                   ))
//                   }
//                 </ul>
//               </div>
//             </div>
//             {selectedProducts.map
//                   ((product,index) =>(
//             <div key={index} className="col-lg-9">
//               <div className="hero__item set-bg" data-setbg={`${baseURL}/Images/${product.images.img}`}
//                   style={{width:'100%', backgroundImage: `url(${baseURL}/Images/${product.images.img})` }}>
//                 <div className="hero__text">
//                   <span>Đặt Món Nhanh</span>
//                   <h2>{product.name}</h2>
//                   <p>Giá {product.price.toLocaleString('vi-VN')} vnđ</p>
//                   <a href="/Shop" className="primary-btn">ĐẶT MÓN NGAY</a>
//                 </div>
//               </div>
//             </div>
//             ))
//             }
//           </div>
//         </div>
//       </section>
//     );
//   };
  
//   export default HeroSection;
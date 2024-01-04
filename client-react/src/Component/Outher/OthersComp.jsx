import Header from "../Header"
import Footer from "../Footer"
import { Outlet } from "react-router-dom"
import handshake from '../../assets/handshake.png'

export default function OthersComp() {
  return (
    <>
     <Header></Header> 
     <div className="flex my-5 text-[#183761] gap-3 px-8 items-center justify-center">
        <img src={handshake} alt="" />
        <p className="text-[14px]">Buy confidently with UirShop Purchase Protection program for buyers, get a full refund in the rare case your item doesn't arrive, arrives damaged, or isn't as described</p>
     </div>
     <Outlet></Outlet>
     <Footer></Footer> 
    </>
  )
}

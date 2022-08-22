import React, { Component } from 'react'

class Sample extends Component {
    constructor(props){
        super(props);
        this.state = {mobile: "Samsung", price: "54000", git_url: "https://github.com/Vik13Rao/dotnet-batch"};
        
    }
  render() {
    return (
      <><div style={{ color: 'Red', fontSize: '30px', fontFamily: 'cursive' }}>Mobile name is {this.state.mobile} and it costs {this.state.price}</div><div>
           <br /> <br /> <a href={this.state.git_url} className='button'> Github link</a> </div></>
    )
  }
}

export default Sample;
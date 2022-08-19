import React, { Component } from 'react';
class Engine extends Component{
    constructor(props){
        super(props);
        this.state = {brand:"Ford", model:"abc"};
        //this.state = {carname: "Ford"};
        //this.state = {carbrandname: "Ford"};
        // this.state = {make: "Ford"};
    }
    render(){
        return(
            <div>
                <h1>My Car Engine is {this.state.brand}</h1>
                
            </div>
        );
    }
}
export default Engine;
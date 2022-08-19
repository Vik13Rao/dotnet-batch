import React, {Component} from 'react';

class Car extends Component{
    constructor(props){
        super(props);
        this.state={brand:"Ford"};
        this.state = {company:"Tesla"};
        this.state ={make:"Ford"};
    }
    render(){
        return(
            <div>
                <h1>My Car is {this.state.make}</h1>
                
            </div>
        );
    }
}
export default Car;